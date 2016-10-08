"use strict";
namespace Board.Controllers {
    export class BoardCtrl {
        static $inject = ["$scope", "boardService", "gameModelService"];
        constructor($scope: ng.IScope,
            public boardService: Board.Services.BoardService,
            gameModelService: Game.Services.GameModel.GameModelService) {
                this.model = gameModelService;
        }
        public model: Game.Services.GameModel.GameModelService;
        
        public makeMove(figureId: number, x: number, y: number): void {
            this.boardService.postMove(figureId, x, y);
        }
        
        get board(): Board.Models.BoardDefinition {
            return this.model.game ? this.model.game.board : undefined;
        }
        set board(boardDefinition: Board.Models.BoardDefinition) {
            if (this.model.game) {
                this.model.game.board = boardDefinition;
            }
        }
    }
}