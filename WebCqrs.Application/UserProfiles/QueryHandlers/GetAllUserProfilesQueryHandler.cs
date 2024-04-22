using MediatR;
using Microsoft.EntityFrameworkCore;
using WebCqrs.Application.UserProfiles.Queries;
using WebCqrs.Dal;
using WebCqrs.Domain.Aggregates.UserProfileAggregate;

namespace WebCqrs.Application.UserProfiles.QueryHandlers
{

    public class GetAllUserProfilesQueryHandler : IRequestHandler<GetAllUserProfiles, IEnumerable<UserProfile>>
    {
        private readonly DataContext _ctx;

        public GetAllUserProfilesQueryHandler(DataContext ctx) { 
            _ctx = ctx;
        }
        public async Task<IEnumerable<UserProfile>> Handle(GetAllUserProfiles request, CancellationToken cancellationToken)
        {
            return await _ctx.UserProfiles.ToListAsync();
        }
    }
}
