using System.Collections.Generic;
using The.Apps.Game.Core.Models;

namespace The.Apps.Game.Web.ViewModels.Questionnaire
{
    public class QuestionViewModel: NamedViewModelBase
    {
        public QuestionType QuestionType { get; set; }
        public List<ChoiceViewModel> Choices { get; set; }
    }
}