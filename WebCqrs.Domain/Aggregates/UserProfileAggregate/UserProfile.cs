namespace WebCqrs.Domain.Aggregates.UserProfileAggregate
{
    public class UserProfile
    {
        private UserProfile() { 
            
        }
        public Guid UserProfileId { get; private set; }
        public string IdentityId { get; private set; }
        public BasicInfo BasicInfo { get; private set; }
        public DateTime DateCreated { get; private set; }
        public DateTime DateModified { get; private set; }

        public static UserProfile CreateUserProfile(string idenityId, BasicInfo basicInfo) { 

            // TO DO: add validation, error handling strategies, error notification strategies

            var userProfile = new UserProfile() { 
                IdentityId = idenityId,
                BasicInfo = basicInfo,
                DateCreated = DateTime.UtcNow,
                DateModified = DateTime.UtcNow
            };
            
            return userProfile;
        }
    }
}
