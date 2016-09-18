using The.Apps.Game.Core.Models;

namespace The.Apps.Game.Web.ViewModels.Questionnaire
{
    public class ChoiceViewModel: NamedViewModelBase
    {
        public string Glyphicon { get; set; }
        public bool IsSelected { get; set; }
    }
}