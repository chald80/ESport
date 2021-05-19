using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ESport.Model;
using ESport.Services.Interface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ESport.Pages.Maps
{
    public class EditModel : PageModel
    {
        [BindProperty]
        public Map Map { get; set; }

        public IMapService MapService;

        public EditModel(IMapService service)
        {
            MapService = service;
        }

        //private readonly IProfileService service;


        public IActionResult OnGet(int id)
        {
            Map = MapService.GetMap(id);
            if (Map == null)
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

            MapService.EditMap(Map);
            return RedirectToPage("./Index");
        }
    }
}
