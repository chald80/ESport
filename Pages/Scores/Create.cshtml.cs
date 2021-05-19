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
    public class CreateModel : PageModel
    {
        public void OnGet()
        {
        }
        [BindProperty]
        public Score Score { get; set; }
        IScoreService scoreService;
        public CreateModel(IScoreService service)
        {
            this.scoreService = service;
        }
        public IActionResult OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            scoreService.AddScore(Score);
            return RedirectToPage("Index");
        }
    }
}
