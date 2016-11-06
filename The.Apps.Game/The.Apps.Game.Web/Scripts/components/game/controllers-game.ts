"use strict";
namespace Game.Controllers {
    export class GameCtrl {
        static $inject = ["$scope", "gameService", "gameModelService"];
        constructor(public $scope: ng.IScope,
            private gameService: Game.Services.GameService,
            gameModelService: Game.Services.GameModel.GameModelService) {
            this.model = gameModelService;
            this.initGame(1);
        }

        public model: Game.Services.GameModel.GameModelService;
        public isDebug: boolean;

        public initGame(id: number): void {
            this.gameService.initGame(id);
        }

        public get isQuestionnaireShowed(): boolean {
            if (!this.model || !this.model.game || !this.model.game.state) {
                return false;
            }
            return this.model.game.state.currentState === Game.Models.GameMainState.STATE_QUESTIONNAIRE;
        }

        public changeTheme(theme: string): void {
            this.gameService.changeTheme(theme);
        }
    }
}