"use strict";
namespace Questionnaire.Models {
    export class QuestionnaireDefinition {
        public static get QUESTION_TYPE_CHOICES(): string { return "choices"; }
        public static get QUESTION_TYPE_TEXT(): string { return "text"; }
        question: Question;
    }
    export class Question {
        questionType: string = QuestionnaireDefinition.QUESTION_TYPE_TEXT;
        questionText: string;
        isQuestionTypeText(): boolean {
            return this.questionType === QuestionnaireDefinition.QUESTION_TYPE_TEXT;
        }
        isQuestionTypeChoices(): boolean {
            return this.questionType === QuestionnaireDefinition.QUESTION_TYPE_CHOICES;
        }
    }
}