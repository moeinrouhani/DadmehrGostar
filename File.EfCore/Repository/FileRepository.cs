using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _0_Framework.InfraStructure;
using Files.Application.File;
using File.Domain.File;
using Microsoft.EntityFrameworkCore;

namespace File.EfCore.Repository
{
    public class FileRepository : RepositoryBase<long, Domain.File.File>, IFileRepository
    {
        private readonly FileContext _context;
        public FileRepository(FileContext context) : base(context)
        {
            _context = context;
        }

        public EditFile GetDetails(long id)
        {
            return _context.Files.Select(x => new EditFile
            {
                ArchiveNo = x.ArchiveNo,
                ClientVisitDate = x.ClientVisitDate,
                ProceederReference = x.ProceederReference,
                Reqester = x.Reqester,
                Summoned = x.Summoned,
                Client = x.Client,
                FileClass = x.FileClass,
                HasMandate = x.HasMandate,
                Description = x.Description,
            }).FirstOrDefault(x => x.Id == id);
        }

        public List<FileViewModel> Search(FileSearchModel searchModel)
        {
            var query = _context.Files.Select(x => new FileViewModel
            {
                Id = x.id,
                ArchiveNo = x.ArchiveNo,
                ClientVisitDate = x.ClientVisitDate,
                ProceederReference = x.ProceederReference,
                Reqester = x.Reqester,
                Summoned = x.Summoned,
                Client = x.Client,
                FileClass = x.FileClass,
                HasMandate = x.HasMandate,
                Description = x.Description,
            });

            //TODO if

            return query.OrderByDescending(x => x.Id).ToList();
        }
    }
}
