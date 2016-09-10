"use strict";
namespace Questionnaire.Controllers {
    export interface IQuestionnaireScope extends ng.IScope {
        questionModel: Questionnaire.Models.QuestionnaireDefinition;
        Ctrl: QuestionnaireCtrl;
    }

    export class QuestionnaireCtrl {
        static $inject = ["$scope", "$http"];
        constructor(protected $scope: IQuestionnaireScope,
            protected $http: ng.IHttpService) {
        }
        public getQuestion(): void {
            this.$http
                .get("/api/guestionnaire/question")
                .then((response: ng.IHttpPromiseCallbackArg<any>) => {
                    this.$scope.questionModel = response.data;
                });
        }
    }
}