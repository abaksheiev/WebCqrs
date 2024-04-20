using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WebCqrs.Dal.Configurations;
using WebCqrs.Domain.Aggregates.PostAggregate;
using WebCqrs.Domain.Aggregates.UserProfileAggregate;

namespace WebCqrs.Dal
{
    public class DataContext : IdentityDbContext
    {
        public DataContext(DbContextOptions options):base(options)
        {
            
        }

        public DbSet<UserProfile> UserProfiles { get; set; }
        public DbSet<Post> Posts { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            IndentityRegistration(builder);

            builder.ApplyConfiguration(new PostCommentConfig());
            builder.ApplyConfiguration(new PostInteractionConfig());
            builder.ApplyConfiguration(new UserProfileConfig());

           
        }

        private static void IndentityRegistration(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new IdentityUserLoginConfig());
            builder.ApplyConfiguration(new IdentityUserRoleConfig());
            builder.ApplyConfiguration(new IdentityUserTokenConfig());
        }
    }
}
