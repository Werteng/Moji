using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Moji.Areas.Identity.Data;
using Moji.Models;

[assembly: HostingStartup(typeof(Moji.Areas.Identity.IdentityHostingStartup))]
namespace Moji.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<MojiContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("MojiContextConnection")));

                services.AddDefaultIdentity<MojiUser>(options => options.SignIn.RequireConfirmedAccount = true)
                    .AddEntityFrameworkStores<MojiContext>();
            });
        }
    }
}