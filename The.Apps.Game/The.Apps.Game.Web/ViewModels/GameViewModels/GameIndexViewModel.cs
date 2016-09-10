using System.Linq;
using System.Collections.Generic;
using The.Apps.Game.Core.Models;
using The.Apps.Game.Web.Extensions.ViewModels;

namespace The.Apps.Game.Web.ViewModels.GameViewModels
{
    public class GameIndexViewModel
    {       
        public GameIndexViewModel(List<GameDescription> games)
        {
            GameList = new GameListViewModel
            {
                Games = games.Select(game => game.ToGameDescriptionListItemViewModel()).ToList()
            };
        }

        public GameListViewModel GameList { get; set; }
    }
}