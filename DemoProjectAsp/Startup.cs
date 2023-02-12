using DemoProjectAsp.DataLayer;
using DemoProjectAsp.Models;
using DemoProjectAsp.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoProjectAsp
{
    public class Startup
    {
        public IConfiguration dconfiguration { get; }

        public Startup(IConfiguration configuration)
        {
            dconfiguration = configuration;
        }
        
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
            services.AddDbContext<BookStoreDbContext>(dbContextOptionBuilder =>
            dbContextOptionBuilder.UseSqlServer(dconfiguration.GetConnectionString("DBConnection")));
            
            //services.AddSingleton<IRepository<Book>, MockBookRepository>();
            services.AddScoped<IRepository<Book>, SqlBookRepository>();
        }
        
        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            //Conventional Routing without attribute: create endpoints to controller actions and specifies routes
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "Default",
                    pattern: "{controller=home}/{action=Index}/{id?}");
                    //defaults: new { controller = "Home", action = "Index" });
            });


            //Attribute Routing
            //app.UseEndpoints(endpoints =>
            //{
            //    endpoints.MapControllers();//Create endpoints to controller actions without specifying routes
            //});
        }
    }
}
