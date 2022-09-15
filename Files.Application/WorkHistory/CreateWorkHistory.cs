using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Files.Application.WorkHistory
{
    public class CreateWorkHistory
    {
        public string FromDate { get; set; }
        public string ToDate { get; set; }
        public int WorkingHoursPerDay { get; set; }
        public int WorkingHoursPerWeek { get; set; }
        public string Description { get; set; }
        public long Petition_Id { get; set; }
    }
}
