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
    internal class EmployeeProjectConfuguration : IEntityTypeConfiguration<EmployeeProject>
    {
        public void Configure(EntityTypeBuilder<EmployeeProject> builder)
        {
            builder
                .ToTable("EmployeeProject")
                .HasKey(p => p.EmployeeProjectId);

          
        }
    }
}
