using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebCqrs.Application.UserProfiles.Commands;
using WebCqrs.Domain.Aggregates.UserProfileAggregate;

namespace WebCqrs.Application.MappingProfiles
{
    internal class UserProfileMap:Profile
    {
        public UserProfileMap() {
            //CreateMap<CreateUserCommand, BasicInfo>;
        }
    }
}
