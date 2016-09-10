using System.Collections.Generic;
using The.Apps.Game.Core.Models;
using The.Apps.Game.Core.Services.Abstract;

namespace The.Apps.Game.Core.Services
{
    public class GameService : IGameService
    {
        public GameDescription GetGame(int gameId)
        {
            return new GameDescription { Id = 1, Name = "Game 1" };
        }

        public List<GameDescription> GetListOfGames()
        {
            return new List<GameDescription>
            {
                new GameDescription { Id = 1, Name = "Game 1" },
                new GameDescription { Id = 2, Name = "Game 2" }
            };
        }
    }
}
