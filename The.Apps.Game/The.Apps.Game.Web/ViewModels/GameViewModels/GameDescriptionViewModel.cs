using The.Apps.Game.Core.Models;

namespace The.Apps.Game.Web.ViewModels.GameViewModels
{
    public class GameDescriptionViewModel : NamedViewModelBase
    {
        public GameDescriptionViewModel(GameDescription gameDescription)
        {
            Id = gameDescription.Id;
            Name = gameDescription.Name;
        }
    }
}