using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Files.Application.Board
{
    public class CreateBoard
    {
        public DateTime DisputeResolutionPetitionDate { get; set; }
        public string Branch { get; set; }
        public string BoardChairman { get; set; }
        public string ExpertReport { get; set; }
        public long File_Id { get; set; }
        public long BoardType_Id { get; set; }

    }
}
