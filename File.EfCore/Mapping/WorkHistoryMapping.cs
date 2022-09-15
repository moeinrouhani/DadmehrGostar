using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using File.Domain.Board;
using File.Domain.WorkHistory;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace File.EfCore.Mapping
{
    public class WorkHistoryMapping : IEntityTypeConfiguration<WorkHistory>
    {
        public void Configure(EntityTypeBuilder<WorkHistory> builder)
        {
            builder.ToTable("WorkHistories");
            builder.HasKey(x => x.id);

            //TODO
            //add validations

            builder.HasOne(x => x.Petition).WithMany(x => x.WorkHistoriesList).HasForeignKey(x => x.Petition_Id);
        }
    }
}
