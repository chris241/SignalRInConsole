using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalRInConsole
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigurServices(IServiceCollection services)
        {
            services.AddSignalR().Services.AddEndpointsApiExplorer();
        }
        public void Configure(IApplicationBuilder app)
        {
            app.UseRouting();
            app.UseEndpoints(endPoints =>
            {
                endPoints.MapHub<ChatHub>("/");
            });
        }

    }
}
