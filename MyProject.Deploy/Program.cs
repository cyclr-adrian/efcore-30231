using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using MyProject.Data;

IHost host = Host.CreateDefaultBuilder(args)
.ConfigureAppConfiguration((config) =>
{
    config.Build();
})
.ConfigureServices((context, services) =>
{
    services.AddDbContext<MyProjectObjectContext>(options =>
    {
        options.UseMySql("Database=cyclr2;DataSource=localhost;Uid=cyclr;Password=cyclr;AllowUserVariables=true;Pooling=true;Convert Zero Datetime=true;", new MySqlServerVersion(new Version(major: 5, minor: 7, build: 37)));
    });
})
.Build();

host.Run();