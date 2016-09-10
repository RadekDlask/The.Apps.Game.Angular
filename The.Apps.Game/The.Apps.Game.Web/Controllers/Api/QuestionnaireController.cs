using System.Collections.Generic;
using System.Web.Http;
using The.Apps.Game.Web.ViewModels.Questionnaire;

namespace The.Apps.Game.Web.Controllers.Api
{
    public class QuestionnaireController : ApiController
    {
        public QuestionViewModel Question(int id)
        {
            return new QuestionViewModel
            {
                Id = id,
                Name = "Question",
                QuestionType = QuestionType.Choices,
                Choices = new List<ChoiceViewModel>
                {
                    new ChoiceViewModel { Id = 1, Name = "My first Choice"},
                    new ChoiceViewModel { Id = 1, Name = "My second Choice"}
                }
            };
        }
    }
}
