using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using TCU_SodaAmira.Areas.Identity.Data;
using TCU_SodaAmira.Data;

[assembly: HostingStartup(typeof(TCU_SodaAmira.Areas.Identity.IdentityHostingStartup))]
namespace TCU_SodaAmira.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<LoginDbContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("LoginDbContextConnection")));

                services.AddDefaultIdentity<UsuariosLogin>(options => options.SignIn.RequireConfirmedAccount = true)
                    .AddEntityFrameworkStores<LoginDbContext>();
            });
        }
    }
}