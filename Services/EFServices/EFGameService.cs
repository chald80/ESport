using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ESport.Model;
using ESport.Services.Interface;

namespace ESport.Services.EFServices
{
    public class EFGameService : IGameService
    {

        ESportContext context;
        public EFGameService(ESportContext service)
        {
            context = service;
        }
        public IEnumerable<Game> GetGames()
        {
            return context.Games;
        }

        public void AddGame(Game game)
        {
            context.Games.Add(game);
            context.SaveChanges();
        }

        public void DeleteGame(Game game)
        {
            context.Games.Remove(game);
            context.SaveChanges();
        }

        public Game GetGame(int id)
        {
            var game= context.Games.FirstOrDefault(g => g.GameId == id);
            return game;
        }

        public void EditGame(Game game)
        {
            context.Games.Update(game);
            context.SaveChanges();
        }
    }
}
