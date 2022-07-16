using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB_codeFirst.DbModels
{
    public class Title
    {
       
        public int Titleid { get; set; }

        public string Name { get; set; }

        public virtual List<Employee> Employees { get; set; } = new List<Employee>();
    }
}
