using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ESport.Model;
using ESport.Services.Interface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ESport.Pages.Games
{
    public class EditModel : PageModel
    {
        [BindProperty]
        public Game Game { get; set; }

        public IGameService GameService;

        public EditModel(IGameService service)
        {
            GameService = service;
        }

        //private readonly IProfileService service;


        public IActionResult OnGet(int id)
        {
            Game = GameService.GetGame(id);
            if (Game == null)
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

            GameService.EditGame(Game);
            return RedirectToPage("./Index");
        }
    }
}
