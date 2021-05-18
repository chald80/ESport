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
    public class IndexModel : PageModel
    {
        public IEnumerable<Game> Games { get; set; }
        public Game Game { get; set; }

        private IGameService context;
        public IndexModel(IGameService service)
        {
            context = service;
        }
        public void OnGet()
        {
            Games = context.GetGames();
        }
    }
}
