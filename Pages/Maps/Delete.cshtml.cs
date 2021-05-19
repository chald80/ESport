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
    public class DeleteModel : PageModel
    {
        [BindProperty]
        public Map Map{ get; set; }

        IMapService mapService;

        public DeleteModel(IMapService service)
        {
            this.mapService = service;
            Map = new Map();
        }
        public void OnGet(int id)
        {
            Map = mapService.GetMap(id);
        }
        public IActionResult OnPost()
        {
            mapService.DeleteMap(Map);

            return RedirectToPage("Index");
        }
    }
}


