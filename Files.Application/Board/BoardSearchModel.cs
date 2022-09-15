using System;

namespace Files.Application.Board
{
    public class BoardSearchModel
    {
        public DateTime DisputeResolutionPetitionDate { get; set; }
        public string Branch { get; set; }
        public string BoardChairman { get; set; }
        public string ExpertReport { get; set; }
        public long File_Id { get; set; }
        public long BoardType_Id { get; set; }

    }
}