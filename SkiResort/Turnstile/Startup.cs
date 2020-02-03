using Data.Context;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore;
using Turnstile.Services.Abstract;
using Turnstile.Services.Concrete;
using Data.Repository.Abstract;
using Data.Repository.Concrete;
using Data.Entities.Card;
using Turnstile.Middleware;

namespace Turnstile
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
            services.AddDbContext<TurnstileContext>(opts => opts.UseSqlServer(Configuration["ConnectionString:SkiResortDb"]));
            services.AddScoped<IResortRepository<Card>, EntityRepository<Card>>();
            services.AddScoped<IResortRepository<Data.Entities.Turnstiles.Turnstile>, EntityRepository<Data.Entities.Turnstiles.Turnstile>>();
            services.AddScoped<ITurnstileService, TurnstileService>();
            services.AddControllers();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {               
                app.UseDeveloperExceptionPage();
                app.UseHandling();
            }
            else
            {
                app.UseHandling();
                app.UseExceptionHandler();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
