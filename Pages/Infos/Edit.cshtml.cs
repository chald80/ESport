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
    public class EditModel : PageModel
    {
        [BindProperty]
        public Info Info { get; set; }

        public IInfoService InfoService;

        public EditModel(IInfoService service)
        {
            InfoService = service;
        }

        //private readonly IProfileService service;


        public IActionResult OnGet(int id)
        {
            Info = InfoService.GetInfo(id);
            if (Info == null)
            {
                return null;

            }

            return Page();

        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            InfoService.EditInfo(Info);
            return RedirectToPage("./Index");
        }
    }
}
