using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _0_Framework.Domain;
using Files.Application.File;

namespace File.Domain.File
{
    public interface IFileRepository : IRepository<long, File>
    {
        EditFile GetDetails(long id);
        List<FileViewModel> Search(FileSearchModel searchModel);
    }
}
