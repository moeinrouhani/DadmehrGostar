using _0_Framework.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace File.Domain.WorkHistory
{
    public class WorkHistory : EntityBase
    {
        public WorkHistory(DateTime fromDate, DateTime toDate, int workingHoursPerDay, int workingHoursPerWeek, string description)
        {
            FromDate = fromDate;
            ToDate = toDate;
            WorkingHoursPerDay = workingHoursPerDay;
            WorkingHoursPerWeek = workingHoursPerWeek;
            Description = description;
        }

        public DateTime FromDate { get; private set; }
        public DateTime ToDate { get; private set; }
        public int WorkingHoursPerDay { get; private set; }
        public int WorkingHoursPerWeek { get; private set; }
        public string Description { get; private set; }

        public void Edit(DateTime fromDate, DateTime toDate, int workingHoursPerDay, int workingHoursPerWeek, string description)
        {
            FromDate = fromDate;
            ToDate = toDate;
            WorkingHoursPerDay = workingHoursPerDay;
            WorkingHoursPerWeek = workingHoursPerWeek;
            Description = description;
        }
    }
}
