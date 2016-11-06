using System.Collections.Generic;
using System.Web.Http;
using The.Apps.Game.Core.Services.Users;
using The.Apps.Game.Web.ViewModels.GameViewModels.GamePlay;
using The.Apps.Game.Web.ViewModels.Questionnaire;

namespace The.Apps.Game.Web.Controllers.Api
{
    public class GameController : ApiController
    {
        [HttpPost]
        public GameResponseViewModel Response(int id, GameMainState gameState, GameResponseViewModel response)
        {
            if (response == null)
            {
                throw new HttpResponseException(System.Net.HttpStatusCode.BadRequest);
            }
            switch (gameState)
            {
                case GameMainState.Questionnaire:
                    return new GameResponseViewModel
                    {
                        GameMainState = new GameMainStateViewModel
                        {
                            CurrentState = GameMainState.Board,
                            Id = 2,
                            Name = "It is your turn.",
                            Url = string.Format("/api/game/reponse?id={0}&state={1}", id, GameMainState.Board)
                        }
                    };
                case GameMainState.Board:
                    return new GameResponseViewModel
                    {
                        GameMainState = new GameMainStateViewModel
                        {
                            CurrentState = GameMainState.Board,
                            Id = 3,
                            Name = "Wait for your oponent.",
                            Url = string.Format("/api/game/reponse?id={0}&state={1}", id, GameMainState.Board)
                        }
                    };
                case GameMainState.Init:
                    return new GameResponseViewModel
                    {
                        GameMainState = new GameMainStateViewModel
                        {
                            CurrentState = GameMainState.Questionnaire,
                            Id = 1,
                            Name = "Game preparation",
                            Url = string.Format("/api/game/reponse?id={0}&state={1}", id, GameMainState.Questionnaire)
                        }
                    };
                default: throw new HttpResponseException(System.Net.HttpStatusCode.BadRequest);
            }
            
        }
        [HttpGet]
        [Authorize(Roles = UserRoles.User)]
        public GameMainViewModel Init(int id)
        {
            if (id < 1)
            {
                throw new HttpResponseException(System.Net.HttpStatusCode.NotFound);
            }
            return new GameMainViewModel
            {
                Id = id,
                Name = "Chess partie",
                GameMainState = new GameMainStateViewModel
                {
                    CurrentState = GameMainState.Questionnaire,
                    Id = 1,
                    Name = "Game preparation",
                    Url = string.Format("/api/game/reponse?id={0}&state={1}", id, GameMainState.Questionnaire)
                },
                Questionaire = new QuestionnaireViewModel
                {
                    Id = 1,
                    Name = "Set up the game.",
                    Question = new QuestionViewModel
                    {
                        Id = 1,
                        Name = "Please select your color. Both or none for random pick.",
                        QuestionType = QuestionType.Choices,
                        Choices = new List<ChoiceViewModel>
                        {
                            new ChoiceViewModel
                            {
                                Id = 1,
                                Name = "White",
                                Glyphicon = "fire"
                            },
                            new ChoiceViewModel
                            {
                                Id = 2,
                                Name = "Black",
                                Glyphicon = "fire"
                            }
                        }
                    }
                }
            };
        }
    }
}
