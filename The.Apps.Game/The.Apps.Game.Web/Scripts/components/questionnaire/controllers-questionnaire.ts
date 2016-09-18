"use strict";
//namespace Questionnaire.Controllers {
//    export interface IQuestionnaireScope extends ng.IScope {
//        questionnaireService: Questionnaire.Services.QuestionnaireService;
//        Ctrl: QuestionnaireCtrl;
//    }

//    export class QuestionnaireCtrl {
//        static $inject = ["$scope", "questionnaireService"];
//        constructor(protected $scope: IQuestionnaireScope,       
//            public questionnaireService: Questionnaire.Services.QuestionnaireService) {
//            //this.$scope.questionnaireService = questionnaireService;
//        }
//        public test = "aaaa";
//        public getQuestion(): void {
//            this.questionnaireService.getQuestion();
//        }
//    }
//}

namespace Questionnaire.Controllers {    
    export class QuestionnaireCtrl {
        static $inject = ["$scope", "questionnaireService", "gameModelService"];
        constructor($scope: ng.IScope,
            public questionnaireService: Questionnaire.Services.QuestionnaireService,
            gameModelService: Game.Services.GameModel.GameModelService) {
                this.model = gameModelService;
        }
        public model: Game.Services.GameModel.GameModelService;
        public getQuestion(): void {
            this.questionnaireService.getQuestionnaire();
        }
        public answerToQuestion(): void {
            this.questionnaireService.postQuestionnaire();
        }
        public isQuestionTypeText(): boolean {
            if (this.questionnaire) {
                return this.questionnaire.question.questionType === Questionnaire.Models.QuestionnaireDefinition.QUESTION_TYPE_TEXT;
            }
            return false;
        }
        public isQuestionTypeChoices(): boolean {
            if (this.questionnaire) {
                return this.questionnaire.question.questionType === Questionnaire.Models.QuestionnaireDefinition.QUESTION_TYPE_CHOICES;
            }
            return false;
        }
        get questionnaire(): Questionnaire.Models.QuestionnaireDefinition {
            return this.model.game ? this.model.game.questionnaire : undefined;
        }
        set questionnaire(questionnaireDefinition: Questionnaire.Models.QuestionnaireDefinition) {
            if (this.model.game) {
                this.model.game.questionnaire = questionnaireDefinition;
            }
        }
        
    }
}