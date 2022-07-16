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
    internal class OfficeConfuguration : IEntityTypeConfiguration<Office>
    {
        public void Configure(EntityTypeBuilder<Office> builder)
        {
            builder
                .ToTable("Office")
                .HasKey(p => p.OfficeId);

           
        }
    }
}
