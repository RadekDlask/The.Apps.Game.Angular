"use strict";
namespace The.Apps {
    export class Game {
        public static app: ng.IModule = angular.module("GameApp", [
            "questionnaireDirective",
            "boardDirective"
        ]);
    }
}
angular.module("questionnaireDirective", []);
angular.module("boardDirective", []);