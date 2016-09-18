"use strict";
namespace Questionnaire.Services {
    export class QuestionnaireService {
        static $inject = ["$http", "urlService", "gameModelService"];
        constructor(
            protected $http: ng.IHttpService,
            protected urlService: Core.Services.UrlService,
            gameModelService: Game.Services.GameModel.GameModelService) {
            this.model = gameModelService;
        }
        public getQuestionnaire(): void {
            this.$http
                .get(this.urlService.questionnaireApi.getQuestionnaire(1))
                .then((response: ng.IHttpPromiseCallbackArg<any>) => {
                    this.model.game.questionnaire = response.data;
                });
        }
        public postQuestionnaire(): void {
            this.$http
                .post(this.urlService.questionnaireApi.postQuestionnaire(), this.model.game.questionnaire)
                .then((response: ng.IHttpPromiseCallbackArg<any>) => {
                    this.model.game.questionnaire = response.data;
                });
        }
        public model: Game.Services.GameModel.GameModelService;

    }
}