using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Marvin.IDP.UserRegistration
{
    public class RegisterUserFromFacebookViewModel
    {
        [Required]
        [MaxLength(250)]
        [Display(Name = "Given name")]
        public string GivenName { get; set; }

        [Required]
        [MaxLength(250)]
        [Display(Name = "Family name")]
        public string FamilyName { get; set; }

        [Required]
        [MaxLength(250)]
        [Display(Name = "Address")]
        public string Address { get; set; }

        [Required]
        [MaxLength(2)]
        [Display(Name = "Country")]
        public string Country { get; set; }

        public string Email { get; set; }
        public string ReturnUrl { get; set; }
        public SelectList CountryCodes { get; set; } =
           new SelectList(
               new[] {
                    new { Id = "BE", Value = "Belgium" },
                    new { Id = "US", Value = "United States of America" },
                    new { Id = "IN", Value = "India" } },
               "Id",
               "Value");

        public string Provider { get; set; }
        public string ProviderUserId { get; set; }



    }
}
