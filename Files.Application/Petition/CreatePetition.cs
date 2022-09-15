using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Files.Application.Petition
{
    public class CreatePetition
    {
        public DateTime PetitionIssuanceDate { get; set; }
        public DateTime NotificationPetitionDate { get; set; }
        public string TotalPenalty { get; set; }
        public string TotalPenaltyTitles { get; set; }
        public string Description { get; set; }
    }
}
