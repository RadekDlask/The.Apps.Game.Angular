"use strict";
namespace Core.Services {
    export class UrlService {
        httpParamSerializer: angular.IHttpParamSerializer;
        static $inject = ["$httpParamSerializer"];
        constructor($httpParamSerializer: ng.IHttpParamSerializer) {
            this.httpParamSerializer = $httpParamSerializer;
            this.game = new GameNavigation($httpParamSerializer);
            this.gameApi = new GameApiNavigation($httpParamSerializer);
            this.questionnaireApi = new QuestionnaireApiNavigation($httpParamSerializer);
        }
        public game: GameNavigation;
        public gameApi: GameApiNavigation;
        public questionnaireApi: QuestionnaireApiNavigation;
    }
    export class GameNavigation {
        httpParamSerializer: angular.IHttpParamSerializer;
        constructor($httpParamSerializer: ng.IHttpParamSerializer) {
            this.httpParamSerializer = $httpParamSerializer;
        }
        public getGameInit(id: number): string {
            return "/game/init?" + this.httpParamSerializer({"id": id});
        }
        public postTheme(theme: string): string {
            return "/game/settheme?" + this.httpParamSerializer({ "theme": theme });
        }
    }
    export class GameApiNavigation {
        httpParamSerializer: angular.IHttpParamSerializer;
        constructor($httpParamSerializer: ng.IHttpParamSerializer) {
            this.httpParamSerializer = $httpParamSerializer;
        }
        public getGameInit(id: number): string {
            return "/api/game/init?" + this.httpParamSerializer({ "id": id });
        }
        public postResponse(id: number, state: number): string {
            return "/api/game/response?" + this.httpParamSerializer({ "id": id, "state": state});
        }
    }
    export class QuestionnaireApiNavigation {
        httpParamSerializer: angular.IHttpParamSerializer;
        constructor($httpParamSerializer: ng.IHttpParamSerializer) {
            this.httpParamSerializer = $httpParamSerializer;
        }
        public getQuestionnaire(id: number): string {
            return "/api/questionnaire/questionnaire?" + this.httpParamSerializer({ "id": id });
        }
        public postQuestionnaire(): string {
            return "/api/questionnaire/questionnaire";
        }
    }
}