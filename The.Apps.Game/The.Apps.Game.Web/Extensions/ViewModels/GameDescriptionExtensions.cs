using The.Apps.Game.Core.Models;
using The.Apps.Game.Web.ViewModels.GameViewModels;

namespace The.Apps.Game.Web.Extensions.ViewModels
{
    internal static class GameDescriptionExtensions
    {
        public static GameListItemViewModel ToGameDescriptionListItemViewModel(this GameDescription gameDescription)
        {
            if (gameDescription == null)
            {
                return null;
            }
            return new GameListItemViewModel { Id = gameDescription.Id, Name = gameDescription.Name };
        }
    }
}