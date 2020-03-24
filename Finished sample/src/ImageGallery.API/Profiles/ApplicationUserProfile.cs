using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ImageGallery.API.Profiles
{
    public class ApplicationUserProfile : Profile
    {
        public ApplicationUserProfile()
        {
            CreateMap<Model.ApplicationUserProfile, Entities.ApplicationUserProfile>().ReverseMap();

            CreateMap<Model.ApplicationUserProfileForCreation, Entities.ApplicationUserProfile>()
               .ForMember(m => m.Id, options => options.Ignore())
               .ForMember(m => m.Subject, options => options.Ignore())
               .ForMember(m => m.SubscriptionLevel, options => options.Ignore());
        }
    }
}
