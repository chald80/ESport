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
    public class EditModel : PageModel
    {
        [BindProperty]
        public Profile Profile { get; set; }

        public IProfileService ProfileService;

        public EditModel(IProfileService service)
        {
            ProfileService = service;
        }

        //private readonly IProfileService service;


        public IActionResult OnGet(int id)
        {
            Profile = ProfileService.GetProfile(id);
            if (Profile == null)
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

            ProfileService.EditProfile(Profile);
            return RedirectToPage("./Index");
        }
    }
}
