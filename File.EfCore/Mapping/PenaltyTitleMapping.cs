using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using File.Domain.PenaltyTitle;
using File.Domain.Petition;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace File.EfCore.Mapping
{
    public class PenaltyTitleMapping : IEntityTypeConfiguration<PenaltyTitle>
    {
        public void Configure(EntityTypeBuilder<PenaltyTitle> builder)
        {
            builder.ToTable("PenaltyTitles");
            builder.HasKey(x => x.id);

            //TODO
            //add validations

            builder.HasOne(x => x.Petition).WithMany(x => x.PenaltyTitlesList).HasForeignKey(x => x.Petition_Id);
        }
    }
}
