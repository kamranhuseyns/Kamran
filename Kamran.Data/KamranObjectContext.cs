using Kamran.Core.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using Kamran.Core;
using Microsoft.Extensions.Configuration;

namespace Kamran.Data
{
    public class KamranObjectContext : DbContext
    {
   
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                .AddJsonFile("appsettings.json")
                .Build();
            optionsBuilder.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));
        }

        public DbSet<Kamran.Core.Domain.Customer> Customer { get; set; }
    }
}
