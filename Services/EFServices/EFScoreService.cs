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

        public void AddGame(Score score)
        {
            context.Scores.Add(score);
            context.SaveChanges();
        }

        public void DeleteGame(Score score)
        {
            context.Scores.Remove(score);
            context.SaveChanges();
        }

        public Score GetScore(int id)
        {
            throw new NotImplementedException();
        }
    }
}
