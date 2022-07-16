using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace DB_codeFirst
{
    public sealed class ApplicationContextFactory : IDesignTimeDbContextFactory<ApplicationContext>
    {
        public ApplicationContext CreateDbContext(string[] args)
        {
            var connectionString = "Data Source=DESKTOP-6S01LM0\\MSSQLSERVER01;Initial Catalog=Application;Integrated Security=True";
            var optionsBuilder = new DbContextOptionsBuilder<ApplicationContext>();
            var options = optionsBuilder
                .UseSqlServer(connectionString)
                .Options;

            return new ApplicationContext(options);
        }
    }
}
