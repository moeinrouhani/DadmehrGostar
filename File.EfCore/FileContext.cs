using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using File.Domain.Board;
using File.Domain.BoardType;
using File.Domain.PenaltyTitle;
using File.Domain.Petition;
using File.Domain.ProceedingSession;
using File.Domain.WorkHistory;
using File.EfCore.Mapping;
using Microsoft.EntityFrameworkCore;

namespace File.EfCore
{
    public class FileContext:DbContext
    {
        public DbSet<Board> Boards { get; set; }
        public DbSet<BoardType> BoardTypes { get; set; }
        public DbSet<Domain.File.File> Files { get; set; }
        public DbSet<PenaltyTitle> PenaltyTitles { get; set; }
        public DbSet<Petition> Petitions { get; set; }
        public DbSet<ProceedingSession> ProceedingSessions { get; set; }
        public DbSet<WorkHistory> WorkHistory { get; set; }


        public FileContext(DbContextOptions<FileContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //TODO add mappings instead of boards
            var assembly = typeof(FileMapping).Assembly;
            modelBuilder.ApplyConfigurationsFromAssembly(assembly);
            base.OnModelCreating(modelBuilder);
        }
    }
}
