using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _0_Framework.Application;

namespace Files.Application.Petition
{
    public interface IPetitionApplication
    {
        OperationResult Create(CreatePetition command);
        OperationResult Edit(EditPetition command);
        EditPetition GetDetails(long id);
        List<PetitionViewModel> Search(PetitionSearchModel searchModel);
    }
}
