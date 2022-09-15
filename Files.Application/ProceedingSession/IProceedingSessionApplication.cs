using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _0_Framework.Application;
using Files.Application.File;

namespace Files.Application.ProceedingSession
{
    public interface IProceedingSessionApplication
    {
        OperationResult Create(CreateProceedingSession command);
        OperationResult Edit(EditProceedingSession command);
    }
}
