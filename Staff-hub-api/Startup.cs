using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore;
using StaffHubApi.Repositories;
using StaffHubApi.Repositories.Contract;
using StaffHubApi.Services;
using StaffHubApi.Repositories.Implementation;
using StaffHubApi.Models.Entities;

namespace StaffHubApi
{
    public class Startup
    {
        public IConfiguration Configuration { get; }

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            services.AddDbContext<StaffHubContext>(op => op.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));

            services.AddScoped<ICommonRepository<Activity>, ActivityRepository>();
            services.AddScoped<ICommonRepository<Client>, ClientRepository>();

            services.AddScoped<ICommonService<Activity>, ActivityService>();
            services.AddScoped<ICommonService<Client>, ClientService>();
            services.AddMvc();            
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                //endpoints.MapControllerRoute("default", "{controller=StaffGroup}/{action=Index}/{id?}");
                endpoints.MapControllers();
            });
        }
    }
}
