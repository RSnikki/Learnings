using DataAccessLayer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using DataAccessLayer.Models;
using DataAccessLayer.Services;
using Microsoft.EntityFrameworkCore;



namespace DemoApi
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
            services.AddControllers();

            services.AddSingleton<IRepository<Book>(new SqlRepository
                (new BookStoreDbContext(new DbContextOptions<BookStoreDbContext>())));

            /*services.AddDbContext<BookStoreDbContext>(dbContextOptionBuilder =>
            dbContextOptionBuilder.UseSqlServer(Configuration.GetConnectionString("DBiConnection")));

            //services.AddSingleton<IRepository<Book>, MockBookRepository>();
            services.AddScoped<IRepository<Book>, SqlRepository>();*/


        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
