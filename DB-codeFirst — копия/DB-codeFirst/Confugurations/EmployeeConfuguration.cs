using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using DB_codeFirst.DbModels;

namespace DB_codeFirst.Confugurations
{
    internal class EmployeeConfuguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder
                .ToTable("Employee")
                .HasKey(p => p.EmployeeId);

            
        }
    }
}
