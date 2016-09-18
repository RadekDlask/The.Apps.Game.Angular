using System;
using System.Collections.Generic;
using System.Web.Http;
using The.Apps.Game.Web.ViewModels.Questionnaire;

namespace The.Apps.Game.Web.Controllers.Api
{
    public class QuestionnaireController : ApiController
    {
        [HttpGet]
        public QuestionnaireViewModel Questionnaire(int id)
        {
            var random = new Random();
            var c1 = random.Next(100000);
            var c2 = random.Next(100000);
            var c3 = random.Next(100000);
            return new QuestionnaireViewModel
            {
                Question = new QuestionViewModel
                {
                    Id = id,
                    Name = string.Format("The Question {0} Name", id),
                    QuestionType = QuestionType.Choices,
                    Choices = new List<ChoiceViewModel>
                    {
                        new ChoiceViewModel
                        {
                            Id = c1,
                            Name = string.Format("Choice {0} Name", c1),
                            Glyphicon = "fire"
                        },
                        new ChoiceViewModel
                        {
                            Id = c2,
                            Name = string.Format("Choice {0} Name", c2),
                            Glyphicon = "fire"
                        },
                        new ChoiceViewModel
                        {
                            Id = c3,
                            Name = string.Format("Choice {0} Name", c3),
                            Glyphicon = "fire"
                        }
                    }
                }
            };
        }
        [HttpPost]
        public QuestionnaireViewModel Questionnaire(QuestionnaireViewModel questionnaire)
        {
            var random = new Random();
            var c1 = random.Next(100000);
            var c2 = random.Next(100000);
            var c3 = random.Next(100000);
            return new QuestionnaireViewModel
            {
                Question = new QuestionViewModel
                {
                    Id = questionnaire.Id,
                    Name = string.Format("The Question {0} Name", questionnaire.Id),
                    QuestionType = QuestionType.Choices,
                    Choices = new List<ChoiceViewModel>
                    {
                        new ChoiceViewModel
                        {
                            Id = c1,
                            Name = string.Format("Choice {0} Name", c1),
                            Glyphicon = "fire"
                        },
                        new ChoiceViewModel
                        {
                            Id = c2,
                            Name = string.Format("Choice {0} Name", c2),
                            Glyphicon = "fire"
                        },
                        new ChoiceViewModel
                        {
                            Id = c3,
                            Name = string.Format("Choice {0} Name", c3),
                            Glyphicon = "fire"
                        }
                    }
                }
            };
        }
    }
}