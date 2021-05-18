using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ESport.Model;
using ESport.Services.Interface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ESport.Pages.Profiles
{
    public class IndexModel : PageModel
    {
        public IEnumerable<Profile> Profiles { get; set; }
        public Profile Profile { get; set; }

        private IProfileService context;
        public IndexModel(IProfileService service)
        {
            context = service;
        }
        public void OnGet()
        {
            Profiles = context.GetProfiles();
        }
    }
}
