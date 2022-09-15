using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Files.Application.File
{
    public class CreateFile
    {
        public long ArchiveNo { get; set; }
        public DateTime ClientVisitDate { get; set; }
        public string ProceederReference { get; set; }
        public long Reqester { get; set; }
        public long Summoned { get; set; }
        public bool Client { get; set; }
        public string FileClass { get; set; }
        public bool HasMandate { get; set; }
        public string Description { get; set; }
    }
}
