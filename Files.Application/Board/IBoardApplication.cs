using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _0_Framework.Application;

namespace Files.Application.Board
{
    public interface IBoardApplication
    {
        OperationResult Create(CreateBoard command);
        OperationResult Edit(EditBoard command);
        EditBoard GetDetails(long id);
        List<BoardViewModel> Search(BoardSearchModel searchModel);
    }
}
