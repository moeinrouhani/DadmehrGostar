using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using File.Domain.Board;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace File.EfCore.Mapping
{
    public class BoardMapping : IEntityTypeConfiguration<Board>
    {
        public void Configure(EntityTypeBuilder<Board> builder)
        {
            builder.ToTable("Boards");
            builder.HasKey(x => x.id);

            //TODO
            //add validations

            builder.HasOne(x => x.File).WithMany(x => x.BoardsList).HasForeignKey(x => x.File_Id);
            builder.HasOne(x => x.BoardType).WithMany(x => x.BoardsList).HasForeignKey(x => x.BoardType_Id);
        }
    }
}
