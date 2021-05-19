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
    public class EditModel : PageModel
    {
        [BindProperty]
        public Score Score { get; set; }

        public IScoreService ScoreService;

        public EditModel(IScoreService service)
        {
            ScoreService = service;
        }

        //private readonly IProfileService service;


        public IActionResult OnGet(int id)
        {
            Score = ScoreService.GetScore(id);
            if (Score == null)
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

            ScoreService.EditScore(Score);
            return RedirectToPage("./Index");
        }
    }
}
