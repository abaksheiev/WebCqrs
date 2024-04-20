using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebCqrs.Domain.Aggregates.PostAggregate;
using WebCqrs.Domain.Aggregates.UserProfileAggregate;

namespace WebCqrs.Dal.Configurations
{
    internal class UserProfileConfig : IEntityTypeConfiguration<UserProfile>
    {
        public void Configure(EntityTypeBuilder<UserProfile> builder)
        {
            
            builder.OwnsOne(up => up.BasicInfo);
        }
    }
}
