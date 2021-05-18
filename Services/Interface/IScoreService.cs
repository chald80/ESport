using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ESport.Model;

namespace ESport.Services.Interface
{
    public interface IScoreService
    {
        IEnumerable<Score> GetScores();
        void AddGame(Score score);
        void DeleteGame(Score score);
        Score GetScore(int id);
    }
}
