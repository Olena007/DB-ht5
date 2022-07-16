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
    public class ClientConfuguration : IEntityTypeConfiguration<Client>
    {
        public void Configure(EntityTypeBuilder<Client> builder)
        {
            builder
                .ToTable("Client")
                .HasKey(p => p.ClientId);


            builder.HasData(new[]
            {
                new Client
                {
                    ClientId = 1,
                    FirstName = "Olena",
                    LastName = "Ivanova",
                    DateOfBirth = new DateTime(1988, 10, 1),
                    Request = "lalal"
                },
                new Client
                {
                    ClientId = 2,
                    FirstName = "Gleb",
                    LastName = "Ivanov",
                    DateOfBirth = new DateTime(1986, 11, 6),
                    Request = "olololol"
                },
                new Client
                {
                    ClientId = 3,
                    FirstName = "Vlad",
                    LastName = "Glech",
                    DateOfBirth = new DateTime(1986, 11, 6),
                    Request = "allalala"
                },
                new Client
                {
                    ClientId = 4,
                    FirstName = "Dima",
                    LastName = "Chern",
                    DateOfBirth = new DateTime(1996, 11, 6),
                    Request = "lslslsls"
                },
                new Client
                {
                    ClientId = 5,
                    FirstName = "Max",
                    LastName = "Kosten",
                    DateOfBirth = new DateTime(1988, 11, 6),
                    Request = "lwlwwllw"
                }
            });
        }
    }
}
