using _0_Framework.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace File.Domain.Board
{
    public class Board : EntityBase
    {
        public Board(DateTime disputeResolutionPetitionDate, string branch, string boardChairman, string expertReport, long fileId, long boardTypeId)
        {
            DisputeResolutionPetitionDate = disputeResolutionPetitionDate;
            Branch = branch;
            BoardChairman = boardChairman;
            ExpertReport = expertReport;
            File_Id = fileId;
            BoardType_Id = boardTypeId;
        }

        public DateTime DisputeResolutionPetitionDate { get; private set; }
        public string Branch { get; private set; }
        public string BoardChairman { get; private set; }
        public string ExpertReport { get; private set; }
        public long File_Id { get; set; }
        public File.File File { get; set; }
        public long BoardType_Id { get; set; }
        public BoardType.BoardType BoardType { get; set; }

        public void Edit(DateTime disputeResolutionPetitionDate, string branch, string boardChairman, string expertReport, long fileId,long boardTypeId)
        {
            DisputeResolutionPetitionDate = disputeResolutionPetitionDate;
            Branch = branch;
            BoardChairman = boardChairman;
            ExpertReport = expertReport;
            File_Id = fileId;
            BoardType_Id = boardTypeId;
        }
    }
}
