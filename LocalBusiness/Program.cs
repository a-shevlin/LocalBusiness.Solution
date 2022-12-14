using LocalBusiness.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;

namespace LocalBusiness
{
  public class Startup
  {
    public Startup(IConfiguration configuration)
    {
      Configuration = configuration;
    }

    public IConfiguration Configuration { get; }

    public void ConfigureServices(IServiceCollection services)
    {
      services.AddDbContext<LocalBusinessContext>(opt =>
        opt.UseMySql(Configuration["ConnectionStrings:DefaultConnection"], ServerVersion.AutoDetect(Configuration["ConnectionStrings:DefaultConnection"])));
      services.AddControllers();

      services.AddSwaggerGen(c =>
      {
        c.SwaggerDoc("v1", new OpenApiInfo { 
          Title = "Local Businesses", 
          Version = "v1",
          Description = "An API containing a list of local businesses",
          TermsOfService = new Uri("https://example.com/terms"),
          Contact = new OpenApiContact
          {
              Name = "Alex Shevlin",
              Email = string.Empty,
              Url = new Uri("https://github.com/alexshevlin"),
          }
        });
      });
    }
    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
      if (env.IsDevelopment())
      {
        app.UseDeveloperExceptionPage();
      }
        app.UseSwagger();

        app.UseSwaggerUI(c => 
        {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "Local Businesses v1");
        c.RoutePrefix = string.Empty;
        });

      // app.UseHttpsRedirection();

      app.UseRouting();

      app.UseAuthorization();

      app.UseEndpoints(endpoints =>
      {
        endpoints.MapControllers();
      });
    }
  }
}
