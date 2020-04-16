using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace LegitProduct.Data.EF
{
    class LegitProductContextFactory : IDesignTimeDbContextFactory<LegitProductDBContext>
    {
        public LegitProductDBContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var connectionString = configuration.GetConnectionString("LegitProductDb");

            var optionsBuilder = new DbContextOptionsBuilder<LegitProductDBContext>();
            optionsBuilder.UseSqlServer(connectionString);

            return new LegitProductDBContext(optionsBuilder.Options);
        }
    }
}
