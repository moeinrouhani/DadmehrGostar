using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _0_Framework.Application;
using Files.Application.File;

namespace Files.Application.WorkHistory
{
    public interface IWorkHistoryApplication
    {
        OperationResult Create(CreateWorkHistory command);
        OperationResult Edit(EditWorkHistory command);
    }
}
