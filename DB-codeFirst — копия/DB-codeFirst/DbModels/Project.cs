using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB_codeFirst.DbModels
{
    public class Project
    {
        public int ProjectId { get; set; }

        public string Name { get; set; }

        public decimal Budget { get; set; }

        public DateTime Starteddate { get; set; }

        public int ClientId { get; set; }

        public virtual Client Client { get; set; }


        public virtual List<EmployeeProject> EmployeeProjects { get; set; } = new List<EmployeeProject>();
    }
}
