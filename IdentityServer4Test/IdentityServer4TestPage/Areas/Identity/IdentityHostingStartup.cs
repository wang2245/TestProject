using System;
using IdentityServer4TestPage.Areas.Identity.Data;
using IdentityServer4TestPage.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

[assembly: HostingStartup(typeof(IdentityServer4TestPage.Areas.Identity.IdentityHostingStartup))]
namespace IdentityServer4TestPage.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<IdentityServer4TestPageContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("IdentityServer4TestPageContextConnection")));

                services.AddDefaultIdentity<IdentityServer4TestPageUser>(options => options.SignIn.RequireConfirmedAccount = true)
                    .AddEntityFrameworkStores<IdentityServer4TestPageContext>();
            });
        }
    }
}