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
    public class IndexModel : PageModel
    {
        public IEnumerable<Info> Infos { get; set; }
        public Info Info { get; set; }

        private IInfoService context;
        public IndexModel(IInfoService service)
        {
            context = service;
        }
        public void OnGet()
        {
            Infos = context.GetInfos();
        }
    }
}
