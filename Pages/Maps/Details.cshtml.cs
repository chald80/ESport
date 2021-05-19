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
    public class DetailsModel : PageModel
    {
        [BindProperty]
        public Map Map { get; set; }

        private IMapService mapService;

        public DetailsModel(IMapService service)
        {
            mapService = service;
        }

        public IActionResult OnGet(int id)
        {
            Map = mapService.GetMap(id);
            return Page();
        }
    }
}
