using Microsoft.AspNetCore.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ImageGallery.API.Authorization
{
    public class SubscriptionLevelRequirement : IAuthorizationRequirement
    {
        public string RequiredSubscriptionLevel { get; }

        public SubscriptionLevelRequirement(string requiredSubscriptionLevel)
        {
            RequiredSubscriptionLevel = requiredSubscriptionLevel;
        }

    }
}
