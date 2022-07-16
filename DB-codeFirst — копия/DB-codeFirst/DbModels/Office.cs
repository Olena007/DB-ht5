using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB_codeFirst.DbModels
{
    public class Office
    {
        public int OfficeId { get; set; }

        public string Title { get; set; }

        public string Location { get; set; }

        public virtual List<Office> Offices { get; set; } = new List<Office>();
    }
}
