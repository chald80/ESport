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
    public class IndexModel : PageModel
    {
        public IEnumerable<Map> Maps { get; set; }
        public Map Map { get; set; }

        private IMapService context;
        public IndexModel(IMapService service)
        {
            context = service;
        }
        public void OnGet()
        {
            Maps = context.GetMaps();
        }
    }
}
