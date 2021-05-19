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
    public class CreateModel : PageModel
    {
        public void OnGet()
        {
        }
        [BindProperty]
        public Map Map { get; set; }
        IMapService mapService;
        public CreateModel(IMapService service)
        {
            this.mapService = service;
        }
        public IActionResult OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            mapService.AddMaps(Map);
            return RedirectToPage("Index");
        }
    }
}
