using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using File.Domain.Petition;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace File.EfCore.Mapping
{
    public class PetitionMapping : IEntityTypeConfiguration<Petition>
    {
        public void Configure(EntityTypeBuilder<Petition> builder)
        {
            builder.ToTable("Petitions");
            builder.HasKey(x => x.id);

            //TODO
            //add validations

            builder.HasOne(x => x.File).WithMany(x => x.PetitionsList).HasForeignKey(x => x.File_Id);
            builder.HasOne(x => x.Board).WithMany(x => x.PetitionsList).HasForeignKey(x => x.Board_Id);
            builder.HasMany(x => x.WorkHistoriesList).WithOne(x => x.Petition).HasForeignKey(x => x.Petition_Id);
            builder.HasMany(x => x.PenaltyTitlesList).WithOne(x => x.Petition).HasForeignKey(x => x.Petition_Id);
        }
    }
}
