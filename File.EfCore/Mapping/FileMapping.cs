using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace File.EfCore.Mapping
{
    public class FileMapping : IEntityTypeConfiguration<Domain.File.File>
    {

        public void Configure(EntityTypeBuilder<Domain.File.File> builder)
        {
            builder.ToTable("Files");
            builder.HasKey(x => x.id);

            //TODO
            //add validations

            builder.HasMany(x => x.BoardsList).WithOne(x => x.File).HasForeignKey(x => x.File_Id);
            builder.HasMany(x => x.PetitionsList).WithOne(x => x.File).HasForeignKey(x => x.File_Id);
        }
    }
}
