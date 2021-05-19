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
        void AddScore(Score score);
        void DeleteScore(Score score);
        Score GetScore(int id);
        public void EditScore(Score score);

    }
}
