using HSCOP.Provider.DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;


using IHost host = CreateHostBuilder().Build();

using IServiceScope scope = host.Services.CreateScope();
IServiceProvider services = scope.ServiceProvider;

try
{
    var dbContext = services.GetRequiredService<ProviderDbContext>();
    if (dbContext.Database.GetPendingMigrations().Any())
    {
        // There are pending migrations, so apply them.
        dbContext.Database.Migrate();
        Console.WriteLine("Migrations applied successfully.");
    }
    else
    {
        Console.WriteLine("No pending migrations to apply.");
    }
}
catch (Exception ex)
{
    Console.WriteLine("Error applying migrations: " + ex.Message);
}

static IHostBuilder CreateHostBuilder() =>
    Host.CreateDefaultBuilder()
        .ConfigureServices((hostContext, services) =>
        {
            services.AddDbContext<ProviderDbContext>(options =>
            {
                var configuration = hostContext.Configuration;
                string connectionString = configuration.GetConnectionString("ConnectionStrings:ProviderDbConnectionString");
                options.UseSqlServer(connectionString);
            });
        });
