using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _0_Framework.Application;

namespace Files.Application.PenaltyTitle
{
    public interface IPenaltyTitleApplication
    {
        OperationResult Create(CreatePenaltyTitle command);
        OperationResult Edit(EditPenaltyTitle command);
    }
}
