using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IdentityServer4TestPage.Areas.Identity.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace IdentityServer4TestPage.Data
{
    public class IdentityServer4TestPageContext : IdentityDbContext<IdentityServer4TestPageUser>
    {
        public IdentityServer4TestPageContext(DbContextOptions<IdentityServer4TestPageContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);

            foreach (var type in builder.Model.GetEntityTypes())
            {
                var tableName = type.GetTableName();
                if (tableName.StartsWith("AspNet"))
                {
                    type.SetTableName(tableName.Substring(6));
                }
            }
        }
    }
}
