using DemoAppDotNet7.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DemoAppDotNet7.Data.Config
{
    public class IdentityRoleConfigurations : IEntityTypeConfiguration<IdentityRole>
    {
        public void Configure(EntityTypeBuilder<IdentityRole> builder)
        {

            builder.HasData(GenerateInitialData());
        }

        private List<IdentityRole> GenerateInitialData()
        {
            var identityRoles = new List<IdentityRole>()
               {
                    new IdentityRole ()
                    {
                        Id= Guid.NewGuid().ToString(),
                        Name="Admin",
                        NormalizedName="admin",
                        ConcurrencyStamp = Guid.NewGuid().ToString(),
                    },
                    new IdentityRole ()
                    {
                        Id= Guid.NewGuid().ToString(),
                        Name="User",
                        NormalizedName="user",
                        ConcurrencyStamp = Guid.NewGuid().ToString(),
                    },
               };

            return identityRoles;
        }
    }
}
