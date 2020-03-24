using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ImageGallery.API.Authorization
{
    public class SubjectMustMatchUserHandler : AuthorizationHandler<SubjectMustMatchUserRequirement>
    {
        private readonly IHttpContextAccessor _httpContextAccessor;

        public SubjectMustMatchUserHandler(
            IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor ??
                throw new ArgumentNullException(nameof(httpContextAccessor));
        }

        protected override Task HandleRequirementAsync(
            AuthorizationHandlerContext context,
            SubjectMustMatchUserRequirement requirement)
        {
            var subjectFromUri = _httpContextAccessor.HttpContext.GetRouteValue("subject").ToString();
            var subjectFromUserObject = context.User.Claims.FirstOrDefault(c => c.Type == "sub")?.Value;

            if (subjectFromUri != subjectFromUserObject)
            {
                context.Fail();
                return Task.CompletedTask;
            } 

            context.Succeed(requirement);
            return Task.CompletedTask;
        }
    }
}
