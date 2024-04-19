namespace WebCqrs.Domain.Aggregates.UserProfileAggregate
{
    public class UserProfile
    {
        public Guid UserProfileId { get; set; }

        public string IdentityId { get; set; }

        public BasicInfo BasicInfo { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }

        public string CurrentCity { get; set; }

    }
}
