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
    public class CreateModel : PageModel
    {
        public void OnGet()
        {
        }
        [BindProperty]
        public Info Info { get; set; }
        IInfoService infoService;
        public CreateModel(IInfoService service)
        {
            this.infoService = service;
        }
        public IActionResult OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            infoService.AddInfo(Info);
            return RedirectToPage("Index");
        }
    }
}
