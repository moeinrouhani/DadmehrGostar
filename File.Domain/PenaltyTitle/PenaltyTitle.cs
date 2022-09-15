using _0_Framework.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace File.Domain.PenaltyTitle
{
    public class PenaltyTitle : EntityBase
    {
        public PenaltyTitle(DateTime fromDate, DateTime toDate, string title, string day, string description)
        {
            FromDate = fromDate;
            ToDate = toDate;
            Title = title;
            Day = day;
            Description = description;
        }

        public DateTime FromDate { get; private set; }
        public DateTime ToDate { get; private set; }
        public string Title { get; private set; }
        public string Day { get; private set; }
        public string Description { get; private set; }

        public void Edit(DateTime fromDate, DateTime toDate, string title, string day, string description)
        {
            FromDate = fromDate;
            ToDate = toDate;
            Title = title;
            Day = day;
            Description = description;
        }
    }
}
