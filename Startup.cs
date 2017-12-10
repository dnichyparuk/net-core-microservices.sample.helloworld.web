using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Http;

namespace net_core_microservices.sample.helloworld.web
{
    public class Startup
    {
        public Startup(IHostingEnvironment env)
        {
        }

        public void Configure(IApplicationBuilder application,
            IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            application.Run(async (context) => 
            {
                await context.Response.WriteAsync("Hello web!");
            });
        }
    }
}