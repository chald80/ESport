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
    public class DeleteModel : PageModel
    {
        [BindProperty]
        public Game Game { get; set; }

        IGameService gameService;

        public DeleteModel(IGameService service)
        {
            this.gameService = service;
            Game = new Game();
        }
        public void OnGet(int id)
        {
            Game = gameService.GetGame(id);
        }
        public IActionResult OnPost()
        {
            gameService.DeleteGame(Game);

            return RedirectToPage("Index");
        }
    }
}
