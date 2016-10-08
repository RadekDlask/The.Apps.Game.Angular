"use strict";
namespace Board.Models {
    export class BoardDefinition {        
        public board: BoardArray;
    }
    export class BoardArray {
        public fields: Array<Array<BoardField>>;
    }
    export class BoardField {
        id: number;
        x: number;
        y: number;
        color: number;
        isSource: boolean;
        isTarget: boolean;
        figureId: number;
    }
}