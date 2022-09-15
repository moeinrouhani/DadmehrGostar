using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _0_Framework.Domain;
using Files.Application.Petition;

namespace File.Domain.Petition
{
    public interface IPetitionRepository : IRepository<long, Petition>
    {
        EditPetition GetDetails(long id);
        List<PetitionViewModel> Search(PetitionSearchModel searchModel);
    }
}
