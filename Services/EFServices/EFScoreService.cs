using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ESport.Model;
using ESport.Services.Interface;

namespace ESport.Services.EFServices
{
    public class EFScoreService : IScoreService
    {
        ESportContext context;
        public EFScoreService(ESportContext service)
        {
            context = service;
        }
        public IEnumerable<Score> GetScores()
        {
            return context.Scores;
        }

        public void AddScore(Score score)
        {
            context.Scores.Add(score);
            context.SaveChanges();
        }

        public void DeleteScore(Score score)
        {
            context.Scores.Remove(score);
            context.SaveChanges();
        }

        public Score GetScore(int id)
        {
            var score = context.Scores.FirstOrDefault(s => s.ScoreId == id);
            return score;
        }

        public void EditScore(Score score)
        {
            context.Scores.Update(score);
            context.SaveChanges();
        }
    }
}
