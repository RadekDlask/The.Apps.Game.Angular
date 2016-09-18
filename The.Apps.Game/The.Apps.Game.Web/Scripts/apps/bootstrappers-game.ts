app.service("LoggingService", () => new Core.Services.LoggingService());
app.service("urlService", Core.Services.UrlService);

app.service("gameModelService", Game.Services.GameModel.GameModelService);

app.controller("QuestionnaireCtrl", Questionnaire.Controllers.QuestionnaireCtrl);
app.service("questionnaireService", Questionnaire.Services.QuestionnaireService);
app.directive("questionnaireDirective", [() => new Questionnaire.Directives.QuestionnaireDirective()]);

app.controller("GameCtrl", Game.Controllers.GameCtrl);
app.service("gameService", Game.Services.GameService);