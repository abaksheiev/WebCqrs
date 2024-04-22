using AutoMapper;
using WebCqrs.Api.Contracts.UserProfile.Requests;
using WebCqrs.Api.Contracts.UserProfile.Responses;
using WebCqrs.Application.UserProfiles.Commands;
using WebCqrs.Domain.Aggregates.UserProfileAggregate;

namespace WebCqrs.Api.MappingProfiles
{
    public class UserProfileMappings : Profile
    {
        public UserProfileMappings()
        {
            CreateMap<UserProfileCreateUpdate, CreateUserCommand>();
            CreateMap<UserProfile, UserProfileResponse>();

            CreateMap<BasicInfo, BasicInformation>();
        }
    }
}
