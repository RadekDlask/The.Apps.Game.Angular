using System.Collections.Generic;
using System.Web.Http;
using The.Apps.Game.Web.ViewModels.GameViewModels.GamePlay;
using The.Apps.Game.Web.ViewModels.Questionnaire;

namespace The.Apps.Game.Web.Controllers.Api
{
    public class GameController : ApiController
    {
        [HttpGet]
        public GameMainViewModel Init(int id)
        {
            if (id < 1)
            {
                throw new HttpResponseException(System.Net.HttpStatusCode.NotFound);
            }
            return new GameMainViewModel
            {
                Id = id,
                Name = "Game " + id,
                Questionaire = new QuestionnaireViewModel
                {
                    Id = 100,
                    Name = "Questionnaire 100 Name",
                    Question = new QuestionViewModel
                    {
                        Id = 1000,
                        Name = "The Question 1000 Name",
                        QuestionType = QuestionType.Choices,
                        Choices = new List<ChoiceViewModel>
                        {
                            new ChoiceViewModel
                            {
                                Id = 10000,
                                Name = "Choice 10000 Name",
                                Glyphicon = "fire"
                            },
                            new ChoiceViewModel
                            {
                                Id = 10001,
                                Name = "Choice 10001 Name",
                                Glyphicon = "fire"
                            }
                        }
                    }
                }
            };
        }
    }
}
