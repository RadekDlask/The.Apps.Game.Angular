using System.Collections.Generic;
using The.Apps.Game.Core.Models;

namespace The.Apps.Game.Core.Services.Abstract
{
    public interface IGameService
    {
        List<GameDescription> GetListOfGames();
        GameDescription GetGame(int gameId);
    }
}
