using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Factory.Models;

public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<FactoryContext>
{
    FactoryContext IDesignTimeDbContextFactory<FactoryContext>.CreateDbContext(string[] args)
    {
        var configuration = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json")
            .Build();

        var builder = new DbContextOptionsBuilder<FactoryContext>();

        builder.UseMySql(configuration["ConnectionStrings:DefaultConnection"],
            ServerVersion.AutoDetect(configuration["ConnectionStrings:DefaultConnection"]));

        return new FactoryContext(builder.Options);
    }
}