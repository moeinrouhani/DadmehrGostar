using _0_Framework.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace File.Domain.File
{
    public class File : EntityBase
    {
        public File(long archiveNo, DateTime clientVisitDate, string proceederReference, long reqester, long summoned, bool client, string fileClass, bool hasMandate, string description)
        {
            ArchiveNo = archiveNo;
            ClientVisitDate = clientVisitDate;
            ProceederReference = proceederReference;
            Reqester = reqester;
            Summoned = summoned;
            Client = client;
            FileClass = fileClass;
            HasMandate = hasMandate;
            Description = description;
            BoardsList = new List<Board.Board>();
            PetitionsList = new List<Petition.Petition>();
        }

        public long ArchiveNo { get; private set; }
        public DateTime ClientVisitDate { get; private set; }
        public string ProceederReference { get; private set; }
        public long Reqester { get; private set; }
        public long Summoned { get; private set; }
        public bool Client { get; private set; }
        public string FileClass { get; private set; }
        public bool HasMandate { get; private set; }
        public string Description { get; private set; }

        public List<Board.Board> BoardsList { get; set; }
        public List<Petition.Petition> PetitionsList { get; set; }

        //public File()
        //{
        //    BoardsList = new List<Board.Board>();
        //}

        public void Edit(long archiveNo, DateTime clientVisitDate, string proceederReference, long reqester, long summoned, bool client, string fileClass, bool hasMandate, string description)
        {
            ArchiveNo = archiveNo;
            ClientVisitDate = clientVisitDate;
            ProceederReference = proceederReference;
            Reqester = reqester;
            Summoned = summoned;
            Client = client;
            FileClass = fileClass;
            HasMandate = hasMandate;
            Description = description;
        }
    }
}
