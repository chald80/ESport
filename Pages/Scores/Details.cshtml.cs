using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ESport.Model;
using ESport.Services.Interface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ESport.Pages.Scores
{
    public class DetailsModel : PageModel
    {
        [BindProperty]
        public Score Score { get; set; }

        private IScoreService scoreService;

        public DetailsModel(IScoreService service)
        {
            scoreService = service;
        }

        public IActionResult OnGet(int id)
        {
            Score = scoreService.GetScore(id);
            return Page();
        }
    }
}
