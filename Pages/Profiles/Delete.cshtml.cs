using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ESport.Model;
using ESport.Services.Interface;

namespace ESport.Pages.Profiles
{
    public class DeleteModel : PageModel
    {
        [BindProperty]
        public Profile Profile { get; set; }

        IProfileService profileService;

        public DeleteModel(IProfileService service)
        {
            this.profileService = service;
            Profile = new Profile();
        }
        public void OnGet(int id)
        {
            Profile = profileService.GetProfile(id);
        }
        public IActionResult OnPost()
        {
            profileService.DeleteProfile(Profile);

            return RedirectToPage("Index");
        }
    }
}
