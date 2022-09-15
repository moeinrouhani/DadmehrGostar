using _0_Framework.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace File.Domain.Petition
{
    public class Petition : EntityBase
    {
        public Petition(DateTime petitionIssuanceDate, DateTime notificationPetitionDate, string totalPenalty, string totalPenaltyTitles, string description)
        {
            PetitionIssuanceDate = petitionIssuanceDate;
            NotificationPetitionDate = notificationPetitionDate;
            TotalPenalty = totalPenalty;
            TotalPenaltyTitles = totalPenaltyTitles;
            Description = description;
        }

        public DateTime PetitionIssuanceDate { get; private set; }
        public DateTime NotificationPetitionDate { get; private set; }
        public string TotalPenalty { get; private set; }
        public string TotalPenaltyTitles { get; private set; }
        public string Description { get; private set; }

        public void Edit(DateTime petitionIssuanceDate, DateTime notificationPetitionDate, string totalPenalty, string totalPenaltyTitles, string description)
        {
            PetitionIssuanceDate = petitionIssuanceDate;
            NotificationPetitionDate = notificationPetitionDate;
            TotalPenalty = totalPenalty;
            TotalPenaltyTitles = totalPenaltyTitles;
            Description = description;
        }
    }
}
