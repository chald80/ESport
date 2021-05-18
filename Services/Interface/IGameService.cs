using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ESport.Model;

namespace ESport.Services.Interface
{
    public interface IGameService
    {
        IEnumerable<Game> GetGames();
        void AddGame(Game game);
        void DeleteGame(Game game);
        Game GetGame(int id);
        public void EditGame(Game game);

    }
}
