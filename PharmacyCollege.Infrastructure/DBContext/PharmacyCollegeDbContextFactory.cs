using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace PharmacyCollege.Infrastructure.DBContext
{
    public class PharmacyCollegeDbContextFactory
    {
        public PharmacyCollegeDbContext CreateDbContext(string[] args)
        {
            var builder = new ConfigurationManager();
            builder.AddJsonFile("appsettings.json");

            var configuration = builder;

            var optionsBuilder = new DbContextOptionsBuilder<PharmacyCollegeDbContext>();

            optionsBuilder.UseSqlServer(configuration.GetConnectionString("DefaultConnection"),
                sqlOptions =>
                {
                    sqlOptions.MigrationsAssembly(Assembly.GetExecutingAssembly().FullName);
                });

            return new PharmacyCollegeDbContext(optionsBuilder.Options);

        }
    }
}
