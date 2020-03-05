using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApsApp.DAL;
using AutoMapper;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SpaApp.BL.Contracts;
using SpaApp.BL.Services;
using SpaApp.Domain.PocoEntities;
using SpaApp.Web.MappingProfiles;

namespace SpaApp.Web
{
    public class Startup
    {
        public IConfiguration Configuration { get; set; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddCors(options => options.AddPolicy("AllowAll", p => p.AllowAnyOrigin()
                                                            .AllowAnyMethod()
                                                            .AllowAnyHeader()));

            var mappingConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new AccommodationProfile());
            });
            IMapper mapper = mappingConfig.CreateMapper();
            services.AddSingleton(mapper);

            services.AddMvc();

            services.AddDbContext<AppDbContext>();
            
           services.AddTransient<IAccommodationService, AccommodationService>();
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseCors("AllowAll");

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
