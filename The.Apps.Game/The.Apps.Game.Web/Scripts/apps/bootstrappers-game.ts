"use strict";
App.Application.app.service("LoggingService", () => new Core.Services.LoggingService());
App.Application.app.service("urlService", Core.Services.UrlService);

App.Application.app.service("gameModelService", Game.Services.GameModel.GameModelService);

App.Application.app.controller("QuestionnaireCtrl", Questionnaire.Controllers.QuestionnaireCtrl);
App.Application.app.service("questionnaireService", Questionnaire.Services.QuestionnaireService);
App.Application.app.directive("questionnaireDirective", [() => new Questionnaire.Directives.QuestionnaireDirective()]);

App.Application.app.controller("GameCtrl", Game.Controllers.GameCtrl);
App.Application.app.service("gameService", Game.Services.GameService);