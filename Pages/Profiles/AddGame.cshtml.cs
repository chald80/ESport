using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Threading.Tasks;
using ESport.Model;
using ESport.Services.Interface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ESport.Pages.Profiles
{
    public class AddGameModel : PageModel
    {
        IGameService gameService;
        public AddGameModel(IGameService service)
        {
            this.gameService = service;
        }
        public void OnGet(int id)
        {
            Game.GameId = id;

        }
        [BindProperty]
        public Game Game { get; set; } = new Game();
        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            gameService.AddGame(Game);

            return RedirectToPage("GetEnrollments");
        }
    }
}
