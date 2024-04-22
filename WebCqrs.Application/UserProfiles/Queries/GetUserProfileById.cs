using MediatR;
using WebCqrs.Domain.Aggregates.UserProfileAggregate;

namespace WebCqrs.Application.UserProfiles.Queries
{
    public class GetUserProfileById: IRequest<UserProfile>
    {
        public Guid UserProfileId { get; set; }
    }
}
