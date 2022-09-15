using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Files.Application.File;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ServiceHost.Areas.Admin.Pages.File.FilePage
{
    public class IndexModel : PageModel
    {
        public FileSearchModel searchModel;
        public List<FileViewModel> viewModels;

        private readonly IFileApplication _FileApplication;

        public IndexModel(IFileApplication FileApplication)
        {
            _FileApplication = FileApplication;
        }

        public void OnGet(FileSearchModel searchModel)
        {
            viewModels = _FileApplication.Search(searchModel);
        }
        public IActionResult OnGetCreate()
        {

            return Partial("./Create");
        }
        public IActionResult OnPostCreate(CreateFile command)
        {
            var result = _FileApplication.Create(command);
            return new JsonResult(result);
        }

        public IActionResult OnGetEdit(long id)
        {
            var job = _FileApplication.GetDetails(id);


            return Partial("Edit", job);
        }



        public JsonResult OnPostEdit(EditFile command)
        {

            if (ModelState.IsValid)
            {

            }


            var result = _FileApplication.Edit(command);

            return new JsonResult(result);


        }
        public IActionResult OnGetDetails(long id)
        {
            var editJob = _FileApplication.GetDetails(id);

            return Partial("Details", editJob);
        }

    }
}
