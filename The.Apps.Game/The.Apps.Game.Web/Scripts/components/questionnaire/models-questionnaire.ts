"use strict";
namespace Questionnaire.Models {
    export class QuestionnaireDefinition {
        public static get QUESTION_TYPE_CHOICES(): number { return 0; }
        public static get QUESTION_TYPE_TEXT(): number { return 1; }        
        public question: Question;
    }
    export class Question {
        public questionType: number = QuestionnaireDefinition.QUESTION_TYPE_TEXT;
        public name: string;
        public id: number;
        public choices: Array<Choice>;
    }
    export class Choice {        
        name: string;
        id: number;
        glyph: string;
        isSelected: boolean;
    }
}