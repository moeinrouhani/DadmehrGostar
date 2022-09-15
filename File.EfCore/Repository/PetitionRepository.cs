using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _0_Framework.InfraStructure;
using Files.Application.Petition;
using File.Domain.File;
using File.Domain.Petition;
using Microsoft.EntityFrameworkCore;

namespace File.EfCore.Repository
{
    public class PetitionRepository : RepositoryBase<long, Petition>, IPetitionRepository
    {
        private readonly FileContext _context;
        public PetitionRepository(FileContext context) : base(context)
        {
            _context = context;
        }

        public EditPetition GetDetails(long id)
        {
            return _context.Petitions.Select(x => new EditPetition
            {
                PetitionIssuanceDate = x.PetitionIssuanceDate,
                NotificationPetitionDate = x.NotificationPetitionDate,
                TotalPenalty = x.TotalPenalty,
                TotalPenaltyTitles = x.TotalPenaltyTitles,
                Description = x.Description,
            }).FirstOrDefault(x => x.Id == id);
        }

        public List<PetitionViewModel> Search(PetitionSearchModel searchModel)
        {
            var query = _context.Petitions.Select(x => new PetitionViewModel
            {
                Id = x.id,
                PetitionIssuanceDate = x.PetitionIssuanceDate,
                NotificationPetitionDate = x.NotificationPetitionDate,
                TotalPenalty = x.TotalPenalty,
                TotalPenaltyTitles = x.TotalPenaltyTitles,
                Description = x.Description,
            });

            //TODO if

            return query.OrderByDescending(x => x.Id).ToList();
        }
    }
}
