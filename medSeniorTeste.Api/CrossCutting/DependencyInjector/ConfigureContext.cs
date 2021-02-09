using AspNetCore.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace AspNetCore.CrossCutting.DependencyInjector
{
  public static class ConfigureContext
  {
    public static void ConfigureDependencyInjector(IServiceCollection serviceCollection)
    {
      serviceCollection.AddDbContext<MyContext>(
          options => options.UseMySql("Server=localhost;Port=3306;Database=aspnetcore;User=root;Pwd=SenhaForte123")
      );
    }
  }
}
