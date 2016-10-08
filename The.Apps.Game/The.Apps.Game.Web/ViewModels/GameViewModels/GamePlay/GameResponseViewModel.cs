using The.Apps.Game.Web.ViewModels.Board;
using The.Apps.Game.Web.ViewModels.Questionnaire;

namespace The.Apps.Game.Web.ViewModels.GameViewModels.GamePlay
{
    public class GameResponseViewModel
    {
        public GameMainStateViewModel GameMainState { get; set; }
        public QuestionnaireViewModel Questionnaire { get; set; }        
        public BoardViewModel Board { get; set; }
    }
}