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
    public class DeleteModel : PageModel
    {
        [BindProperty]
        public Score Score { get; set; }

        IScoreService scoreService;

        public DeleteModel(IScoreService service)
        {
            this.scoreService = service;
            Score = new Score();
        }
        public void OnGet(int id)
        {
            Score = scoreService.GetScore(id);
        }
        public IActionResult OnPost()
        {
            scoreService.DeleteScore(Score);

            return RedirectToPage("Index");
        }
    }
}


