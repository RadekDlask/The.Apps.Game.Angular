using Newtonsoft.Json;
using The.Apps.Game.Core.Models;
using The.Apps.Game.Web.ViewModels.Questionnaire;

namespace The.Apps.Game.Web.ViewModels.GameViewModels.GamePlay
{
    [JsonObject("game")]
    public class GameMainViewModel : NamedViewModelBase
    {
        [JsonProperty(PropertyName = "questionnaire")]
        public QuestionnaireViewModel Questionaire { get; set; }
    }
}