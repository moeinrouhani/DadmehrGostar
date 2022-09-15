using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using File.Domain.Board;
using File.Domain.ProceedingSession;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace File.EfCore.Mapping
{
    public class ProceedingSessionMapping : IEntityTypeConfiguration<ProceedingSession>
    {
        public void Configure(EntityTypeBuilder<ProceedingSession> builder)
        {
            builder.ToTable("ProceedingSessions");
            builder.HasKey(x => x.id);

            //TODO
            //add validations

            builder.HasOne(x => x.Board).WithMany(x => x.ProceedingSessionsList).HasForeignKey(x => x.Board_Id);
        }
    }
}
