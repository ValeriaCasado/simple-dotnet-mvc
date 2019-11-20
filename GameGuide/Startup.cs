using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
 
namespace GameGuide
{
  public class Startup
  {
 
    public Startup(IHostingEnvironment env)
    {
      var builder = new ConfigurationBuilder()
          .SetBasePath(env.ContentRootPath)
          .AddEnvironmentVariables();
      Configuration = builder.Build();
    }
 
    public IConfigurationRoot Configuration { get; }
 
 //Adds MVC configurations
    public void ConfigureServices(IServiceCollection services)
    {
      services.AddMvc();
    }
    /*
    CONFIGURE is probably THE MOST IMPORTANT FUNCTION HERE
    - It decides what is the first thing that loads
    - Since the controllers are in charge of the app,
    it decides WHICH function in the controller is the
    first thing to load
    - As you can see here controller=Food action=Index and we
    don't need and ID
     */
    public void Configure(IApplicationBuilder app)
    {
      app.UseMvc(routes =>
      {
          routes.MapRoute(
              name: "default",
              template: "{controller=Game}/{action=Index}/{id?}");
      });
     
      /*
      Anthony will understand if you show him what happends
      after this is removed
       */
      app.Run(async (context) =>
      {
          await context.Response.WriteAsync("Hello World!");
      });
 
      //This gives you more detailed error messages
      app.UseDeveloperExceptionPage();
 
    }
 
    }
}