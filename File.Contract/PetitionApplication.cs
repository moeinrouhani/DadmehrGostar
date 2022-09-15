using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _0_Framework.Application;
using Files.Application.Petition;
using File.Domain.Petition;

namespace File.Contract
{
    public class PetitionApplication : IPetitionApplication
    {
        private readonly IPetitionRepository _petitionRepository;

        public PetitionApplication(IPetitionRepository petitionRepository)
        {
            _petitionRepository = petitionRepository;
        }

        public OperationResult Create(CreatePetition command)
        {
            var operation = new OperationResult();

            //TODO if
            //if(_BoardRepository.Exists(x=>x.Branch == command.Branch))
            //    operation.Failed("fail message")

            var petition = new Petition(command.PetitionIssuanceDate, command.NotificationPetitionDate,
                command.TotalPenalty, command.TotalPenaltyTitles, command.Description);
            _petitionRepository.Create(petition);
            _petitionRepository.SaveChanges();

            return operation.Succcedded();
        }

        public OperationResult Edit(EditPetition command)
        {
            var operation = new OperationResult();
            var petition = _petitionRepository.Get(command.Id);

            //TODO
            //if(_BoardRepository.Exists(x=>x.Branch == command.Branch))
            //    operation.Failed("fail message")

            petition.Edit(command.PetitionIssuanceDate, command.NotificationPetitionDate,
                command.TotalPenalty, command.TotalPenaltyTitles, command.Description);
            _petitionRepository.Create(petition);
            _petitionRepository.SaveChanges();

            return operation.Succcedded();
        }

        public EditPetition GetDetails(long id)
        {
            return _petitionRepository.GetDetails(id);
        }

        public List<PetitionViewModel> Search(PetitionSearchModel searchModel)
        {
            return _petitionRepository.Search(searchModel);
        }
    }
}
