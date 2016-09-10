app.controller("GameCtrl", Game.Controllers.GameCtrl);
app.controller("QuestionnaireCtrl", Questionnaire.Controllers.QuestionnaireCtrl);
app.directive("questionnaireDirective", [() => new Questionnaire.Directives.QuestionnaireDirective()]);
app.service("LoggingService", () => new Core.Services.LoggingService());
