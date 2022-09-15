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
        public PenaltyTitle(DateTime fromDate, DateTime toDate, string title, string day, string description, long petition_Id)
        {
            FromDate = fromDate;
            ToDate = toDate;
            Title = title;
            Day = day;
            Description = description;
            Petition_Id = petition_Id;
        }

        public DateTime FromDate { get; private set; }
        public DateTime ToDate { get; private set; }
        public string Title { get; private set; }
        public string Day { get; private set; }
        public string Description { get; private set; }
        public long Petition_Id { get; private set; }
        public Petition.Petition Petition { get; set; }

        public void Edit(DateTime fromDate, DateTime toDate, string title, string day, string description, long petition_Id)
        {
            FromDate = fromDate;
            ToDate = toDate;
            Title = title;
            Day = day;
            Description = description;
            Petition_Id = petition_Id;
        }
    }
}
