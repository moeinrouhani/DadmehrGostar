using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _0_Framework.Application;
using File.Domain.WorkHistory;
using Files.Application.File;
using Files.Application.WorkHistory;

namespace File.Contract
{
    public class WorkHistoryApplication : IWorkHistoryApplication
    {
        private readonly IWorkHistoryRepository _workHistoryRepository;

        public WorkHistoryApplication(IWorkHistoryRepository fileRepository)
        {
            _workHistoryRepository = fileRepository;
        }

        public OperationResult Create(CreateWorkHistory command)
        {
            var operation = new OperationResult();

            var fromDate = new DateTime();
            fromDate = command.FromDate.ToGeorgian();

            var toDate = new DateTime();
            toDate = command.ToDate.ToGeorgian();

            //TODO if
            //if(_BoardRepository.Exists(x=>x.Branch == command.Branch))
            //    operation.Failed("fail message")

            var workHistory = new WorkHistory(fromDate, toDate, command.WorkingHoursPerDay, command.WorkingHoursPerWeek, command.Description,command.Petition_Id);
            _workHistoryRepository.Create(workHistory);
            _workHistoryRepository.SaveChanges();

            return operation.Succcedded();
        }

        public OperationResult Edit(EditWorkHistory command)
        {
            var operation = new OperationResult();
            var workHistory = _workHistoryRepository.Get(command.Id);

            var fromDate = new DateTime();
            fromDate = command.FromDate.ToGeorgian();

            var toDate = new DateTime();
            toDate = command.ToDate.ToGeorgian();

            //TODO
            //if(_BoardRepository.Exists(x=>x.Branch == command.Branch))
            //    operation.Failed("fail message")

            workHistory.Edit(fromDate, toDate, command.WorkingHoursPerDay, command.WorkingHoursPerWeek, command.Description,command.Petition_Id);
            _workHistoryRepository.SaveChanges();

            return operation.Succcedded();
        }

    }
}
