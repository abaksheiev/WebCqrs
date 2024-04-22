using MediatR;
using WebCqrs.Domain.Aggregates.UserProfileAggregate;

namespace WebCqrs.Application.UserProfiles.Queries
{
    public class GetAllUserProfiles : IRequest<IEnumerable<UserProfile>>
    {

    }
}
