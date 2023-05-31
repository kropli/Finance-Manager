using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Options;

namespace DataBaseContext
{
    internal class DataBaseContextFactory : IDesignTimeDbContextFactory<AppDbContext>
    {
        public AppDbContext CreateDbContext(string[] args)
        {
            var configuration = new ConfigurationBuilder()
            .AddJsonFile("appsettings.json")
            .Build();

            string DBPath = configuration["DBPath"];

            var options = new DbContextOptionsBuilder<AppDbContext>()
                .UseSqlite($"Data Source={DBPath}")
                .Options;

            return new AppDbContext(options);
        }
    }
}
