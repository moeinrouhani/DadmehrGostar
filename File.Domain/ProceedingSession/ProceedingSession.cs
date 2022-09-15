using _0_Framework.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace File.Domain.ProceedingSession
{
    public class ProceedingSession : EntityBase
    {
        public ProceedingSession(DateTime date, DateTime time)
        {
            Date = date;
            Time = time;
            //Board_Id = boardId;
        }

        public DateTime Date { get; private set; }
        public DateTime Time { get; private set; }
        //public long Board_Id { get; set; }
        //public Board.Board Board { get; set; }

        public void Edit(DateTime date, DateTime time)
        {
            Date = date;
            Time = time;
            //Board_Id = boardId;
        }
    }
}
