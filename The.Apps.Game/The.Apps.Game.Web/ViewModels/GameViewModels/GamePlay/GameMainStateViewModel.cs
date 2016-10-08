using The.Apps.Game.Core.Models;

namespace The.Apps.Game.Web.ViewModels.GameViewModels.GamePlay
{
    public class GameMainStateViewModel : NamedViewModelBase
    {
        public GameMainState CurrentState { get; set; }
        public string Url { get; set; }
    }
}