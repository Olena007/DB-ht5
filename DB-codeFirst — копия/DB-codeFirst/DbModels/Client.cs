using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB_codeFirst.DbModels
{
    public class Client
    {
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int ClientId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime DateOfBirth { get; set; }

        public string Request { get; set; }

        public virtual List<Project> Clients { get; set; } = new List<Project>();
    }
}
