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
    internal class ProjectConfuguration : IEntityTypeConfiguration<Project>
    {
        public void Configure(EntityTypeBuilder<Project> builder)
        {
            builder
                .ToTable("Project")
                .HasKey(p => p.ProjectId);


            builder.HasData(new[]
            {
                new Project
                {
                    ProjectId = 1,
                    Name = "alal",
                    Budget = 500,
                    Starteddate = new DateTime(2022, 7, 1),
                    ClientId = 1
                },
                new Project
                {
                    ProjectId = 2,
                    Name = "ooops",
                    Budget = 300,
                    Starteddate = new DateTime(2022, 6, 1),
                    ClientId = 1
                },
                new Project
                {
                    ProjectId = 3,
                    Name = "nononono",
                    Budget = 560987,
                    Starteddate = new DateTime(2022, 5, 1),
                    ClientId = 2
                },
                new Project
                {
                    ProjectId = 4,
                    Name = "ooopSSs",
                    Budget = 234,
                    Starteddate = new DateTime(2022, 4, 1),
                    ClientId = 3
                },
                new Project
                {
                    ProjectId = 5,
                    Name = "oOOoops",
                    Budget = 300,
                    Starteddate = new DateTime(2022, 1, 1),
                    ClientId = 4
                },
                new Project
                {
                    ProjectId = 6,
                    Name = "FGGFG",
                    Budget = 2345,
                    Starteddate = new DateTime(2022, 2, 1),
                    ClientId = 5
                }

            });
        }
    }
}
