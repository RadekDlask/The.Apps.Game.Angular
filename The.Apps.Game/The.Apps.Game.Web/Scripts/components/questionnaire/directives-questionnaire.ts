"use strict";
namespace Questionnaire.Directives {
    export class QuestionnaireDirective implements ng.IDirective {
        public restrict: string = "E";
        public replace: boolean = false;
        public templateUrl: string = "/template/questionnaire";
        public controller: string = "QuestionnaireCtrl";
        public controllerAs: string = "Ctrl";
        public scope = {};
    }
}