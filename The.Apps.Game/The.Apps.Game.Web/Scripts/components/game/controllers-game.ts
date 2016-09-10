"use strict";
namespace Game.Controllers {
    export interface IGameScope extends ng.IScope {
        gameModel: Game.Models.GameDefinition;
        Ctrl: GameCtrl;
    }

    export class GameCtrl {
        static $inject = ["$scope", "$http"];
        constructor(protected $scope: IGameScope,
            protected $http: ng.IHttpService) {

        }
        public getQuestion(): void {
            this.$http
                .get("/api/game/play/1")
                .then((response: ng.IHttpPromiseCallbackArg<any>) => {
                    this.$scope.gameModel = response.data;
                });
        }
    }
}