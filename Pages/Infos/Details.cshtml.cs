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
    public class DetailsModel : PageModel
    {
        [BindProperty]
        public Info Info { get; set; }

        private IInfoService infoService;

        public DetailsModel(IInfoService service)
        {
            infoService = service;
        }

        public IActionResult OnGet(int id)
        {
            Info = infoService.GetInfo(id);
            return Page();
        }
    }
}
