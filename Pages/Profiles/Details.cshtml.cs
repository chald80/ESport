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
    public class DetailsModel : PageModel
    {
        [BindProperty]
        public Profile Profile { get; set; }

        private IProfileService profileService;

        public DetailsModel(IProfileService service)
        {
            profileService = service;
        }

        public IActionResult OnGet(int id)
        {
            Profile = profileService.GetProfile(id);
            return Page();
        }
    }
}
