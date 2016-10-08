"use strict";
namespace Board.Directives {
    export class BoardDirective implements ng.IDirective {
        public restrict: string = "E";
        public replace: boolean = false;
        public templateUrl: string = "/template/board";
        public controller: string = "BoardCtrl";
        public controllerAs: string = "boardCtrl";
        public scope = {};
    }
}