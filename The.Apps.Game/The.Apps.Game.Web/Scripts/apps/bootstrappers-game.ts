"use strict";
The.Apps.Game.app.service("LoggingService", () => new Core.Services.LoggingService());
The.Apps.Game.app.service("urlService", Core.Services.UrlService);

The.Apps.Game.app.service("gameModelService", Game.Services.GameModel.GameModelService);

The.Apps.Game.app.controller("QuestionnaireCtrl", Questionnaire.Controllers.QuestionnaireCtrl);
The.Apps.Game.app.service("questionnaireService", Questionnaire.Services.QuestionnaireService);
The.Apps.Game.app.directive("questionnaireDirective", [() => new Questionnaire.Directives.QuestionnaireDirective()]);

The.Apps.Game.app.controller("BoardCtrl", Board.Controllers.BoardCtrl);
The.Apps.Game.app.service("boardService", Board.Services.BoardService);
The.Apps.Game.app.directive("boardDirective", [() => new Board.Directives.BoardDirective()]);

The.Apps.Game.app.controller("GameCtrl", Game.Controllers.GameCtrl);
The.Apps.Game.app.service("gameService", Game.Services.GameService);