"use strict";
namespace Game.Models {
    export class GameDefinition {
        name: string;
        id: number;
        questionnaire: Questionnaire.Models.QuestionnaireDefinition;
    }
}