using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Marvin.IDP.UserRegistration
{
    public class RegisterUserFromFacebookInputViewModel
    {
        public string GivenName { get; set; }
        public string FamilyName { get; set; }
        public string Email { get; set; }
        public string Provider { get; set; }
        public string ProviderUserId { get; set; }
    }

}
