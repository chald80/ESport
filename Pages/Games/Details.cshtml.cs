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
    public class DetailsModel : PageModel
    {
        [BindProperty]
        public Game Game { get; set; }

        private IGameService gameService;

        public DetailsModel(IGameService service)
        {
            gameService = service;
        }

        public IActionResult OnGet(int id)
        {
            Game = gameService.GetGame(id);
            return Page();
        }
    }
}
