using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ESport.Model;
using ESport.Services.Interface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ESport.Pages.Infos
{
    public class DeleteModel : PageModel
    {
        [BindProperty]
        public Info Info { get; set; }

        IInfoService infoService;

        public DeleteModel(IInfoService service)
        {
            this.infoService = service;
            Info = new Info();
        }
        public void OnGet(int id)
        {
            Info = infoService.GetInfo(id);
        }
        public IActionResult OnPost()
        {
            infoService.DeleteInfo(Info);

            return RedirectToPage("Index");
        }
    }
}

