"use strict";
namespace App {
    export class Application {
        public static app: ng.IModule = angular.module("GameApp", [
            "questionnaireDirective"
        ]);
    }
}
angular.module("questionnaireDirective", []);