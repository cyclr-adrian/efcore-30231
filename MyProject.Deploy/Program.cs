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
        options.UseMySql("Database=my_project_db;DataSource=localhost;Uid=my_project_user;Password=my_project_password;AllowUserVariables=true;Pooling=true;Convert Zero Datetime=true;", new MySqlServerVersion(new Version(major: 5, minor: 7, build: 37)));
    });
})
.Build();

host.Run();