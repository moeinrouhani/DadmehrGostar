using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _0_Framework.Application;
using File.Domain.File;
using File.Domain.PenaltyTitle;
using Files.Application.File;
using Files.Application.PenaltyTitle;

namespace File.Contract
{
    public class PenaltyTitleApplication:IPenaltyTitleApplication
    {
        private readonly IPenaltyTitleRepository _penaltyTitleRepository;

        public PenaltyTitleApplication(IPenaltyTitleRepository penaltyTitleRepository)
        {
            _penaltyTitleRepository = penaltyTitleRepository;
        }

        public OperationResult Create(CreatePenaltyTitle command)
        {
            var operation = new OperationResult();

            var FromDate = new DateTime();
            FromDate = command.FromDate.ToGeorgian();

            var ToDate = new DateTime();
            ToDate = command.ToDate.ToGeorgian();

            //TODO if
            //if(_BoardRepository.Exists(x=>x.Branch == command.Branch))
            //    operation.Failed("fail message")

            var penaltyTitle = new PenaltyTitle(FromDate,ToDate,command.Title,command.Day,command.Description,command.Petition_Id);
            _penaltyTitleRepository.Create(penaltyTitle);
            _penaltyTitleRepository.SaveChanges();

            return operation.Succcedded();
        }

        public OperationResult Edit(EditPenaltyTitle command)
        {
            var operation = new OperationResult();
            var penaltyTitle = _penaltyTitleRepository.Get(command.Id);

            var FromDate = new DateTime();
            FromDate = command.FromDate.ToGeorgian();

            var ToDate = new DateTime();
            ToDate = command.ToDate.ToGeorgian();

            //TODO
            //if(_BoardRepository.Exists(x=>x.Branch == command.Branch))
            //    operation.Failed("fail message")

            penaltyTitle.Edit(FromDate, ToDate, command.Title, command.Day, command.Description,command.Petition_Id);
            _penaltyTitleRepository.SaveChanges();

            return operation.Succcedded();
        }
    }
}
