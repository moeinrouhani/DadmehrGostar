using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _0_Framework.Domain;
using Files.Application.Board;

namespace File.Domain.Board
{
    public interface IBoardRepository : IRepository<long, Board>
    {
        EditBoard GetDetails(long id);
        List<BoardViewModel> Search(BoardSearchModel searchModel);
    }
}
