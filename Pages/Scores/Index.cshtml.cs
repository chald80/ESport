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
    public class IndexModel : PageModel
    {
        public IEnumerable<Score> Scores { get; set; }
        public Score Score { get; set; }

        private IScoreService context;
        public IndexModel(IScoreService service)
        {
            context = service;
        }
        public void OnGet()
        {
            Scores = context.GetScores();
        }
    }
}
