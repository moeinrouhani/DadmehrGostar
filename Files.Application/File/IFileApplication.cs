using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _0_Framework.Application;

namespace Files.Application.File
{
    public interface IFileApplication
    {
        OperationResult Create(CreateFile command);
        OperationResult Edit(EditFile command);
        EditFile GetDetails(long id);
        List<FileViewModel> Search(FileSearchModel searchModel);
    }
}
