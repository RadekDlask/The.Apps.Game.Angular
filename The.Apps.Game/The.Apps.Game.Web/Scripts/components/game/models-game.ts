"use strict";
namespace Game.Models {    
    export class GameDefinition {        
        name: string;
        id: number;
        state: GameMainState;
        questionnaire: Questionnaire.Models.QuestionnaireDefinition;
        board: Board.Models.BoardDefinition;
    }
    export class GameMainState {
        public static get STATE_INIT(): number { return 0; }
        public static get STATE_QUESTIONNAIRE(): number { return 1; }
        public static get STATE_BOARD(): number { return 2; }
        currentState: number;
        url: string;
    }
}