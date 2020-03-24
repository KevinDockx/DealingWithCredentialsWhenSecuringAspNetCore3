using IdentityModel;
using IdentityServer4.Services;
using Marvin.IDP.Services;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Marvin.IDP.UserRegistration
{
    public class UserRegistrationController : Controller
    {
        private readonly ILocalUserService _localUserService;
        private readonly IIdentityServerInteractionService _interaction;

        public UserRegistrationController(
            ILocalUserService localUserService,
            IIdentityServerInteractionService interaction)
        {
            _localUserService = localUserService ??
                throw new ArgumentNullException(nameof(localUserService));
            _interaction = interaction ??
                throw new ArgumentNullException(nameof(interaction));
        }

        [HttpGet]
        public async Task<IActionResult> ActivateUser(string securityCode)
        {
            if (await _localUserService.ActivateUser(securityCode))
            {
                ViewData["Message"] = "Your account was successfully activated.  " +
                    "Navigate to your client application to log in.";
            }
            else
            {
                ViewData["Message"] = "Your account couldn't be activated, " +
                    "please contact your administrator.";
            }

            await _localUserService.SaveChangesAsync();

            return View();
        }

        [HttpGet]
        public IActionResult RegisterUser(string returnUrl)
        {
            var vm = new RegisterUserViewModel()
            { ReturnUrl = returnUrl };
            return View(vm);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> RegisterUser(RegisterUserViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var userToCreate = new Entities.User
            {
                Username = model.UserName,
                Subject = Guid.NewGuid().ToString(),
                Email = model.Email,
                Active = false
            };

            userToCreate.Claims.Add(new Entities.UserClaim()
            {
                Type = "country",
                Value = model.Country
            });

            userToCreate.Claims.Add(new Entities.UserClaim()
            {
                Type = JwtClaimTypes.Address,
                Value = model.Address
            });

            userToCreate.Claims.Add(new Entities.UserClaim()
            {
                Type = JwtClaimTypes.GivenName,
                Value = model.GivenName
            });

            userToCreate.Claims.Add(new Entities.UserClaim()
            {
                Type = JwtClaimTypes.FamilyName,
                Value = model.FamilyName
            });

            _localUserService.AddUser(userToCreate, model.Password);
            await _localUserService.SaveChangesAsync();

            // create an activation link
            var link = Url.ActionLink("ActivateUser", "UserRegistration",
                new { securityCode = userToCreate.SecurityCode });

            Debug.WriteLine(link);

            return View("ActivationCodeSent");

            //// log the user in
            //await HttpContext.SignInAsync(userToCreate.Subject, userToCreate.Username);

            //// continue with the flow     
            //if (_interaction.IsValidReturnUrl(model.ReturnUrl)
            //    || Url.IsLocalUrl(model.ReturnUrl))
            //{
            //    return Redirect(model.ReturnUrl);
            //}

            //return Redirect("~/");

        }

        [HttpGet]
        public IActionResult RegisterUserFromFacebook(RegisterUserFromFacebookInputViewModel model)
        {
            if (model is null)
            {
                throw new ArgumentNullException(nameof(model));
            }

            return View(new RegisterUserFromFacebookViewModel()
            {
                GivenName = model.GivenName,
                FamilyName = model.FamilyName,
                Email = model.Email,
                Provider = model.Provider,
                ProviderUserId = model.ProviderUserId

            });
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> RegisterUserFromFacebook(
            RegisterUserFromFacebookViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            // create claims
            var claims = new List<Claim>()
            {
                new Claim(JwtClaimTypes.Email, model.Email),
                new Claim(JwtClaimTypes.GivenName, model.GivenName),
                new Claim(JwtClaimTypes.FamilyName, model.FamilyName),
                new Claim(JwtClaimTypes.Address, model.Address),
                new Claim("country", model.Country)
            };

            // provision the user
            _localUserService.
                ProvisionUserFromExternalIdentity(model.Provider, model.ProviderUserId, claims);
            await _localUserService.SaveChangesAsync();

            // redirect             
            return RedirectToAction("Callback", "External");

        }

    }
}
