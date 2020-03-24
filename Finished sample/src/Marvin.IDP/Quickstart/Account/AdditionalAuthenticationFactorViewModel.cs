using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Marvin.IDP
{
    public class AdditionalAuthenticationFactorViewModel
    {
        public string ReturnUrl { get; set; }
        public bool RememberLogin { get; set; }
        [Required]
        public string Totp { get; set; }

    }
}
