"use strict";
namespace Game.Services {
    export class GameService {
        static $inject = ["$http", "urlService", "gameModelService"];
        constructor(
            protected $http: ng.IHttpService,
            protected urlService: Core.Services.UrlService,
            gameModelService: Game.Services.GameModel.GameModelService) {
                this.model = gameModelService;
        }
        public model: Game.Services.GameModel.GameModelService;
        public initGame(id: number): void {
            this.$http
                .get(this.urlService.gameApi.getGameInit(id))
                .then((response: ng.IHttpPromiseCallbackArg<any>) => {
                    this.model.game = response.data;
                });
        }
    }
}