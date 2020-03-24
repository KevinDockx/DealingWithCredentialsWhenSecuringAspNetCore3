using AutoMapper;
using ImageGallery.API.Services;
using ImageGallery.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ImageGallery.API.Controllers
{
    [Route("api/applicationuserprofiles")]
    [ApiController]
    [Authorize]
    public class ApplicationUserProfilesController : ControllerBase
    {
        private readonly IGalleryRepository _galleryRepository;
        private readonly IMapper _mapper;

        public ApplicationUserProfilesController(
            IGalleryRepository galleryRepository, 
            IMapper mapper)
        {
            _galleryRepository = galleryRepository ??
                throw new ArgumentNullException(nameof(galleryRepository)); 
            _mapper = mapper ??
                throw new ArgumentNullException(nameof(mapper));
        }

        [Authorize(Policy = "SubjectMustMatchUser")]
        [HttpGet("{subject}", Name = "GetApplicationUserProfile")]
        public IActionResult GetApplicationUserProfile(string subject)
        {
            var applicationUserProfileFromRepo = _galleryRepository
                .GetApplicationUserProfile(subject);

            if (applicationUserProfileFromRepo == null)
            {
                // subject must come from token
                var subjectFromToken = User.Claims.FirstOrDefault(c => c.Type == "sub").Value;

                applicationUserProfileFromRepo = new Entities.ApplicationUserProfile()
                {
                    Subject = subject,
                    SubscriptionLevel = "FreeUser"
                };

                _galleryRepository.AddApplicationUserProfile(applicationUserProfileFromRepo);
                _galleryRepository.Save();
            }

            return Ok(_mapper.Map<Model.ApplicationUserProfile>(applicationUserProfileFromRepo));
        }

        [HttpPost()]
        public IActionResult CreateApplicationUserProfile(
            [FromBody] ApplicationUserProfileForCreation applicationUserProfileForCreation)
        {
            // currently the ApplicationUserProfileForCreation object doesn't have any properties,
            // as only the subscriptionlevel can be set and that's set to FreeUser for all
            // new users.  ApplicationUserProfileForCreation is accepted as an example
            // for when you would create a client-level screen where the user must input
            // field values before the profile can be created.  
                        
            var subject = User.Claims.FirstOrDefault(c => c.Type == "sub").Value;

            if (_galleryRepository.ApplicationUserProfileExists(subject))
            {
                return BadRequest();
            }

            var applicationUserProfileEntity = 
                _mapper.Map<Entities.ApplicationUserProfile>(applicationUserProfileForCreation);

            // subject must come from the token 
            applicationUserProfileEntity.Subject = subject;

            // subscriptionlevel = FreeUser
            applicationUserProfileEntity.SubscriptionLevel = "FreeUser";
             
            _galleryRepository.AddApplicationUserProfile(applicationUserProfileEntity);

            _galleryRepository.Save();

            var applicationUserProfileToReturn = _mapper.Map<Image>(applicationUserProfileEntity);

            return CreatedAtRoute("GetApplicationUserProfile",
                new { 
                    id = applicationUserProfileToReturn.Id 
                },
                applicationUserProfileToReturn);
        }
    }
}
