"use strict";
namespace Board.Services {
    export class BoardService {
        static $inject = ["$http", "urlService", "gameModelService"];
        constructor(
            protected $http: ng.IHttpService,
            protected urlService: Core.Services.UrlService,
            gameModelService: Game.Services.GameModel.GameModelService) {
            this.model = gameModelService;
        }        
        public postMove(figureId: number, x: number, y: number): void {
            this.$http
                .post(this.model.game.state.url, null)
                .then((response: ng.IHttpPromiseCallbackArg<any>) => {
                    this.model.game.questionnaire = response.data;
                });
        }
        public model: Game.Services.GameModel.GameModelService;

    }
}