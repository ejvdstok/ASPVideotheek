using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASP_Eindtest.Services;
using Data.Models;
using Data.Repositories;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace ASP_Eindtest
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddSession();
            services.AddDbContext<VideoVerhuurContext>(options =>
             options.UseSqlServer(
             Configuration.GetConnectionString("VideoConnection"),
             x => x.MigrationsAssembly("Data")));
            services.AddControllersWithViews();
            services.AddTransient<KlantService>();
            services.AddTransient<IKlantRepository, SQLKlantRepository>();
            services.AddTransient<GenreService>();
            services.AddTransient<IGenreRepository, SQLGenreRepository>();
            services.AddSingleton<WinkelmandService>();
            services.AddTransient<FilmService>();
            services.AddTransient<IFilmRepository, SQLFilmRepository>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }
            app.UseStaticFiles();
            app.UseSession();


            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    
    }
}
