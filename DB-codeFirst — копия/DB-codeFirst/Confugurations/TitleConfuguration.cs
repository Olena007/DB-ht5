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
    internal class TitleConfuguration : IEntityTypeConfiguration<Title>
    {
        public void Configure(EntityTypeBuilder<Title> builder)
        {
            builder
                .ToTable("Title")
                .HasKey(p => p.Titleid);

        }
    }
}
