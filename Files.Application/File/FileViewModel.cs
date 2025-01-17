﻿using System;

namespace Files.Application.File
{
    public class FileViewModel
    {
        public long Id { get; set; }
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