using MediatR;
using Microsoft.EntityFrameworkCore;
using WebCqrs.Application.UserProfiles.Queries;
using WebCqrs.Dal;
using WebCqrs.Domain.Aggregates.UserProfileAggregate;

namespace WebCqrs.Application.UserProfiles.QueryHandlers
{
    internal class GetUserProfileByIdHandler : IRequestHandler<GetUserProfileById, UserProfile>
    {
        private readonly DataContext _ctx;

        public GetUserProfileByIdHandler(DataContext ctx)
        {
            _ctx = ctx;
        }
        public async Task<UserProfile> Handle(GetUserProfileById request, CancellationToken cancellationToken)
        {
            var up = await _ctx.UserProfiles.FirstOrDefaultAsync(up => up.UserProfileId == request.UserProfileId);

            return up;
        }
    }
}
