using AutoMapper;
using MediatR;
using System.Numerics;
using WebCqrs.Application.UserProfiles.Commands;
using WebCqrs.Dal;
using WebCqrs.Domain.Aggregates.UserProfileAggregate;

namespace WebCqrs.Application.UserProfiles.CommandHandlers
{
    public class CreateUserCommandHandler : IRequestHandler<CreateUserCommand, UserProfile>
    {
        private readonly DataContext _ctx;
        private readonly IMapper _mapper;

        public CreateUserCommandHandler(DataContext ctx, IMapper mapper)
        {
            _ctx = ctx;
            _mapper = mapper;
        }
        async Task<UserProfile> IRequestHandler<CreateUserCommand, UserProfile>.Handle(CreateUserCommand request, CancellationToken cancellationToken)
        {
            var basicInfo = BasicInfo.CreatedBasicInfo(
            request.FirstName,
            request.LastName,
            request.EmailAddress,
            request.Phone,
            request.DateOfBirth,
            request.CurrentCity);

            var userProfile = UserProfile.CreateUserProfile(Guid.NewGuid().ToString(), basicInfo);

            _ctx.UserProfiles.Add(userProfile);
            await _ctx.SaveChangesAsync();

            return userProfile; 
        }
    }
}
