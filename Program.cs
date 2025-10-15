using Lab5.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using var host = Host.CreateDefaultBuilder(args).ConfigureServices((context, services) =>
{ 
    services.AddDbContext<DatabaseContext> (options =>
    options.UseSqlServer("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = master;Integrated Security = True; Connect Timeout = 30; Encrypt = False; Trust Server Certificate = False; Application Intent = ReadWrite; Multi Subnet Failover = False"));
})
.Build();