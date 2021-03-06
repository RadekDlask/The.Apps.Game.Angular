﻿// <auto-generated />
// This file was generated by a T4 template.
// Don't change it directly as your change would get overwritten.  Instead, make changes
// to the .tt file (i.e. the T4 template) and save it to regenerate this file.

// Make sure the compiler doesn't complain about missing Xml comments and CLS compliance
// 0108: suppress "Foo hides inherited member Foo. Use the new keyword if hiding was intended." when a controller and its abstract parent are both processed
// 0114: suppress "Foo.BarController.Baz()' hides inherited member 'Qux.BarController.Baz()'. To make the current member override that implementation, add the override keyword. Otherwise add the new keyword." when an action (with an argument) overrides an action in a parent controller
#pragma warning disable 1591, 3008, 3009, 0108, 0114
#region T4MVC

using System;
using System.Diagnostics;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Web;
using System.Web.Hosting;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;
using System.Web.Mvc.Html;
using System.Web.Routing;
using T4MVC;

[GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
public static partial class MVC
{
    public static The.Apps.Game.Web.Controllers.AccountController Account = new The.Apps.Game.Web.Controllers.T4MVC_AccountController();
    public static The.Apps.Game.Web.Controllers.GameController Game = new The.Apps.Game.Web.Controllers.T4MVC_GameController();
    public static The.Apps.Game.Web.Controllers.HomeController Home = new The.Apps.Game.Web.Controllers.T4MVC_HomeController();
    public static The.Apps.Game.Web.Controllers.TemplateController Template = new The.Apps.Game.Web.Controllers.T4MVC_TemplateController();
    public static The.Apps.Game.Web.Controllers.TestController Test = new The.Apps.Game.Web.Controllers.T4MVC_TestController();
    public static T4MVC.BoardController Board = new T4MVC.BoardController();
    public static T4MVC.QuestionnaireController Questionnaire = new T4MVC.QuestionnaireController();
    public static T4MVC.SharedController Shared = new T4MVC.SharedController();
}

namespace T4MVC
{
}

namespace T4MVC
{
    [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
    public class Dummy
    {
        private Dummy() { }
        public static Dummy Instance = new Dummy();
    }
}

[GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
internal partial class T4MVC_System_Web_Mvc_ActionResult : System.Web.Mvc.ActionResult, IT4MVCActionResult
{
    public T4MVC_System_Web_Mvc_ActionResult(string area, string controller, string action, string protocol = null): base()
    {
        this.InitMVCT4Result(area, controller, action, protocol);
    }
     
    public override void ExecuteResult(System.Web.Mvc.ControllerContext context) { }
    
    public string Controller { get; set; }
    public string Action { get; set; }
    public string Protocol { get; set; }
    public RouteValueDictionary RouteValueDictionary { get; set; }
}



namespace Links
{
    [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
    public static class Scripts {
        public const string UrlPath = "~/Scripts";
        public static string Url() { return T4MVCHelpers.ProcessVirtualPath(UrlPath); }
        public static string Url(string fileName) { return T4MVCHelpers.ProcessVirtualPath(UrlPath + "/" + fileName); }
        public static readonly string _references_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(UrlPath + "/_references.min.js") ? Url("_references.min.js") : Url("_references.js");
        public static readonly string angular = Url("angular");
        public static readonly string angular_mocks_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(UrlPath + "/angular-mocks.min.js") ? Url("angular-mocks.min.js") : Url("angular-mocks.js");
        public static readonly string angular_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(UrlPath + "/angular.min.js") ? Url("angular.min.js") : Url("angular.js");
        public static readonly string angular_min_js = Url("angular.min.js");
        public static readonly string angular_min_js_map = Url("angular.min.js.map");
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public static class apps {
            public const string UrlPath = "~/Scripts/apps";
            public static string Url() { return T4MVCHelpers.ProcessVirtualPath(UrlPath); }
            public static string Url(string fileName) { return T4MVCHelpers.ProcessVirtualPath(UrlPath + "/" + fileName); }
            public static readonly string apps_game_ts = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(UrlPath + "/apps-game.min.js") ? Url("apps-game.min.js") : Url("apps-game.js");
            public static readonly string bootstrappers_game_ts = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(UrlPath + "/bootstrappers-game.min.js") ? Url("bootstrappers-game.min.js") : Url("bootstrappers-game.js");
        }
    
        public static readonly string bootstrap = Url("bootstrap");
        public static readonly string bootstrap_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(UrlPath + "/bootstrap.min.js") ? Url("bootstrap.min.js") : Url("bootstrap.js");
        public static readonly string bootstrap_min_js = Url("bootstrap.min.js");
        public static readonly string common = Url("common");
        public static readonly string modernizr_2_6_2_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(UrlPath + "/modernizr-2.6.2.min.js") ? Url("modernizr-2.6.2.min.js") : Url("modernizr-2.6.2.js");
        public static readonly string respond_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(UrlPath + "/respond.min.js") ? Url("respond.min.js") : Url("respond.js");
        public static readonly string respond_min_js = Url("respond.min.js");
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public static class components {
            public const string UrlPath = "~/Scripts/components";
            public static string Url() { return T4MVCHelpers.ProcessVirtualPath(UrlPath); }
            public static string Url(string fileName) { return T4MVCHelpers.ProcessVirtualPath(UrlPath + "/" + fileName); }
            [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
            public static class board {
                public const string UrlPath = "~/Scripts/components/board";
                public static string Url() { return T4MVCHelpers.ProcessVirtualPath(UrlPath); }
                public static string Url(string fileName) { return T4MVCHelpers.ProcessVirtualPath(UrlPath + "/" + fileName); }
                public static readonly string controllers_board_ts = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(UrlPath + "/controllers-board.min.js") ? Url("controllers-board.min.js") : Url("controllers-board.js");
                public static readonly string directives_board_ts = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(UrlPath + "/directives-board.min.js") ? Url("directives-board.min.js") : Url("directives-board.js");
                public static readonly string models_board_ts = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(UrlPath + "/models-board.min.js") ? Url("models-board.min.js") : Url("models-board.js");
                public static readonly string services_board_ts = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(UrlPath + "/services-board.min.js") ? Url("services-board.min.js") : Url("services-board.js");
            }
        
            [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
            public static class common {
                public const string UrlPath = "~/Scripts/components/common";
                public static string Url() { return T4MVCHelpers.ProcessVirtualPath(UrlPath); }
                public static string Url(string fileName) { return T4MVCHelpers.ProcessVirtualPath(UrlPath + "/" + fileName); }
                public static readonly string services_logging_ts = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(UrlPath + "/services-logging.min.js") ? Url("services-logging.min.js") : Url("services-logging.js");
                public static readonly string services_url_ts = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(UrlPath + "/services-url.min.js") ? Url("services-url.min.js") : Url("services-url.js");
            }
        
            [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
            public static class game {
                public const string UrlPath = "~/Scripts/components/game";
                public static string Url() { return T4MVCHelpers.ProcessVirtualPath(UrlPath); }
                public static string Url(string fileName) { return T4MVCHelpers.ProcessVirtualPath(UrlPath + "/" + fileName); }
                public static readonly string controllers_game_ts = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(UrlPath + "/controllers-game.min.js") ? Url("controllers-game.min.js") : Url("controllers-game.js");
                public static readonly string models_game_ts = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(UrlPath + "/models-game.min.js") ? Url("models-game.min.js") : Url("models-game.js");
                public static readonly string services_game_model_ts = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(UrlPath + "/services-game-model.min.js") ? Url("services-game-model.min.js") : Url("services-game-model.js");
                public static readonly string services_game_ts = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(UrlPath + "/services-game.min.js") ? Url("services-game.min.js") : Url("services-game.js");
            }
        
            [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
            public static class questionnaire {
                public const string UrlPath = "~/Scripts/components/questionnaire";
                public static string Url() { return T4MVCHelpers.ProcessVirtualPath(UrlPath); }
                public static string Url(string fileName) { return T4MVCHelpers.ProcessVirtualPath(UrlPath + "/" + fileName); }
                public static readonly string controllers_questionnaire_ts = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(UrlPath + "/controllers-questionnaire.min.js") ? Url("controllers-questionnaire.min.js") : Url("controllers-questionnaire.js");
                public static readonly string directives_questionnaire_ts = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(UrlPath + "/directives-questionnaire.min.js") ? Url("directives-questionnaire.min.js") : Url("directives-questionnaire.js");
                public static readonly string models_questionnaire_ts = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(UrlPath + "/models-questionnaire.min.js") ? Url("models-questionnaire.min.js") : Url("models-questionnaire.js");
                public static readonly string services_questionnaire_ts = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(UrlPath + "/services-questionnaire.min.js") ? Url("services-questionnaire.min.js") : Url("services-questionnaire.js");
            }
        
        }
    
        public static readonly string jquery = Url("jquery");
        public static readonly string jquery_1_10_2_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(UrlPath + "/jquery-1.10.2.min.js") ? Url("jquery-1.10.2.min.js") : Url("jquery-1.10.2.js");
        public static readonly string jquery_1_10_2_intellisense_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(UrlPath + "/jquery-1.10.2.intellisense.min.js") ? Url("jquery-1.10.2.intellisense.min.js") : Url("jquery-1.10.2.intellisense.js");
        public static readonly string jquery_1_10_2_min_js = Url("jquery-1.10.2.min.js");
        public static readonly string jquery_1_10_2_min_map = Url("jquery-1.10.2.min.map");
        public static readonly string jquery_validate_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(UrlPath + "/jquery.validate.min.js") ? Url("jquery.validate.min.js") : Url("jquery.validate.js");
        public static readonly string jquery_validate_vsdoc_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(UrlPath + "/jquery.validate-vsdoc.min.js") ? Url("jquery.validate-vsdoc.min.js") : Url("jquery.validate-vsdoc.js");
        public static readonly string jquery_validate_min_js = Url("jquery.validate.min.js");
        public static readonly string jquery_validate_unobtrusive_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(UrlPath + "/jquery.validate.unobtrusive.min.js") ? Url("jquery.validate.unobtrusive.min.js") : Url("jquery.validate.unobtrusive.js");
        public static readonly string jquery_validate_unobtrusive_min_js = Url("jquery.validate.unobtrusive.min.js");
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public static class page {
            public const string UrlPath = "~/Scripts/page";
            public static string Url() { return T4MVCHelpers.ProcessVirtualPath(UrlPath); }
            public static string Url(string fileName) { return T4MVCHelpers.ProcessVirtualPath(UrlPath + "/" + fileName); }
            public static readonly string page_ts = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(UrlPath + "/page.min.js") ? Url("page.min.js") : Url("page.js");
        }
    
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public static class typings {
            public const string UrlPath = "~/Scripts/typings";
            public static string Url() { return T4MVCHelpers.ProcessVirtualPath(UrlPath); }
            public static string Url(string fileName) { return T4MVCHelpers.ProcessVirtualPath(UrlPath + "/" + fileName); }
            [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
            public static class angularjs {
                public const string UrlPath = "~/Scripts/typings/angularjs";
                public static string Url() { return T4MVCHelpers.ProcessVirtualPath(UrlPath); }
                public static string Url(string fileName) { return T4MVCHelpers.ProcessVirtualPath(UrlPath + "/" + fileName); }
                public static readonly string angular_animate_d_ts = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(UrlPath + "/angular-animate.d.min.js") ? Url("angular-animate.d.min.js") : Url("angular-animate.d.js");
                public static readonly string angular_component_router_d_ts = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(UrlPath + "/angular-component-router.d.min.js") ? Url("angular-component-router.d.min.js") : Url("angular-component-router.d.js");
                public static readonly string angular_cookies_d_ts = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(UrlPath + "/angular-cookies.d.min.js") ? Url("angular-cookies.d.min.js") : Url("angular-cookies.d.js");
                public static readonly string angular_mocks_d_ts = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(UrlPath + "/angular-mocks.d.min.js") ? Url("angular-mocks.d.min.js") : Url("angular-mocks.d.js");
                public static readonly string angular_resource_d_ts = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(UrlPath + "/angular-resource.d.min.js") ? Url("angular-resource.d.min.js") : Url("angular-resource.d.js");
                public static readonly string angular_route_d_ts = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(UrlPath + "/angular-route.d.min.js") ? Url("angular-route.d.min.js") : Url("angular-route.d.js");
                public static readonly string angular_sanitize_d_ts = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(UrlPath + "/angular-sanitize.d.min.js") ? Url("angular-sanitize.d.min.js") : Url("angular-sanitize.d.js");
                public static readonly string angular_d_ts = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(UrlPath + "/angular.d.min.js") ? Url("angular.d.min.js") : Url("angular.d.js");
            }
        
            [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
            public static class jquery {
                public const string UrlPath = "~/Scripts/typings/jquery";
                public static string Url() { return T4MVCHelpers.ProcessVirtualPath(UrlPath); }
                public static string Url(string fileName) { return T4MVCHelpers.ProcessVirtualPath(UrlPath + "/" + fileName); }
                public static readonly string jquery_d_ts = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(UrlPath + "/jquery.d.min.js") ? Url("jquery.d.min.js") : Url("jquery.d.js");
            }
        
        }
    
    }

    [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
    public static class Content {
        public const string UrlPath = "~/Content";
        public static string Url() { return T4MVCHelpers.ProcessVirtualPath(UrlPath); }
        public static string Url(string fileName) { return T4MVCHelpers.ProcessVirtualPath(UrlPath + "/" + fileName); }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public static class bootstrap {
            public const string UrlPath = "~/Content/bootstrap";
            public static string Url() { return T4MVCHelpers.ProcessVirtualPath(UrlPath); }
            public static string Url(string fileName) { return T4MVCHelpers.ProcessVirtualPath(UrlPath + "/" + fileName); }
            public static readonly string alerts_less = Url("alerts.less");
            public static readonly string badges_less = Url("badges.less");
            public static readonly string bootstrap_black_less = Url("bootstrap-black.less");
            public static readonly string bootstrap_black_css = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(UrlPath + "/bootstrap-black.min.css") ? Url("bootstrap-black.min.css") : Url("bootstrap-black.css");
            public static readonly string bootstrap_black_min_css = Url("bootstrap-black.min.css");
            public static readonly string bootstrap_less = Url("bootstrap.less");
            public static readonly string breadcrumbs_less = Url("breadcrumbs.less");
            public static readonly string button_groups_less = Url("button-groups.less");
            public static readonly string buttons_less = Url("buttons.less");
            public static readonly string carousel_less = Url("carousel.less");
            public static readonly string close_less = Url("close.less");
            public static readonly string code_less = Url("code.less");
            public static readonly string component_animations_less = Url("component-animations.less");
            public static readonly string dropdowns_less = Url("dropdowns.less");
            public static readonly string forms_less = Url("forms.less");
            public static readonly string glyphicons_less = Url("glyphicons.less");
            public static readonly string grid_less = Url("grid.less");
            public static readonly string input_groups_less = Url("input-groups.less");
            public static readonly string jumbotron_less = Url("jumbotron.less");
            public static readonly string labels_less = Url("labels.less");
            public static readonly string list_group_less = Url("list-group.less");
            public static readonly string media_less = Url("media.less");
            [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
            public static class mixins {
                public const string UrlPath = "~/Content/bootstrap/mixins";
                public static string Url() { return T4MVCHelpers.ProcessVirtualPath(UrlPath); }
                public static string Url(string fileName) { return T4MVCHelpers.ProcessVirtualPath(UrlPath + "/" + fileName); }
                public static readonly string alerts_less = Url("alerts.less");
                public static readonly string background_variant_less = Url("background-variant.less");
                public static readonly string border_radius_less = Url("border-radius.less");
                public static readonly string buttons_less = Url("buttons.less");
                public static readonly string center_block_less = Url("center-block.less");
                public static readonly string clearfix_less = Url("clearfix.less");
                public static readonly string forms_less = Url("forms.less");
                public static readonly string gradients_less = Url("gradients.less");
                public static readonly string grid_framework_less = Url("grid-framework.less");
                public static readonly string grid_less = Url("grid.less");
                public static readonly string hide_text_less = Url("hide-text.less");
                public static readonly string image_less = Url("image.less");
                public static readonly string labels_less = Url("labels.less");
                public static readonly string list_group_less = Url("list-group.less");
                public static readonly string nav_divider_less = Url("nav-divider.less");
                public static readonly string nav_vertical_align_less = Url("nav-vertical-align.less");
                public static readonly string opacity_less = Url("opacity.less");
                public static readonly string pagination_less = Url("pagination.less");
                public static readonly string panels_less = Url("panels.less");
                public static readonly string progress_bar_less = Url("progress-bar.less");
                public static readonly string reset_filter_less = Url("reset-filter.less");
                public static readonly string reset_text_less = Url("reset-text.less");
                public static readonly string resize_less = Url("resize.less");
                public static readonly string responsive_visibility_less = Url("responsive-visibility.less");
                public static readonly string size_less = Url("size.less");
                public static readonly string tab_focus_less = Url("tab-focus.less");
                public static readonly string table_row_less = Url("table-row.less");
                public static readonly string text_emphasis_less = Url("text-emphasis.less");
                public static readonly string text_overflow_less = Url("text-overflow.less");
                public static readonly string vendor_prefixes_less = Url("vendor-prefixes.less");
            }
        
            public static readonly string mixins_less = Url("mixins.less");
            public static readonly string modals_less = Url("modals.less");
            public static readonly string navbar_less = Url("navbar.less");
            public static readonly string navs_less = Url("navs.less");
            public static readonly string normalize_less = Url("normalize.less");
            public static readonly string pager_less = Url("pager.less");
            public static readonly string pagination_less = Url("pagination.less");
            public static readonly string panels_less = Url("panels.less");
            public static readonly string popovers_less = Url("popovers.less");
            public static readonly string print_less = Url("print.less");
            public static readonly string progress_bars_less = Url("progress-bars.less");
            public static readonly string responsive_embed_less = Url("responsive-embed.less");
            public static readonly string responsive_utilities_less = Url("responsive-utilities.less");
            public static readonly string scaffolding_less = Url("scaffolding.less");
            public static readonly string tables_less = Url("tables.less");
            public static readonly string theme_less = Url("theme.less");
            public static readonly string thumbnails_less = Url("thumbnails.less");
            public static readonly string tooltip_less = Url("tooltip.less");
            public static readonly string type_less = Url("type.less");
            public static readonly string utilities_less = Url("utilities.less");
            public static readonly string variables_less = Url("variables.less");
            public static readonly string wells_less = Url("wells.less");
        }
    
        public static readonly string bootstrap_css = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(UrlPath + "/bootstrap.min.css") ? Url("bootstrap.min.css") : Url("bootstrap.css");
        public static readonly string bootstrap_min_css = Url("bootstrap.min.css");
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public static class fonts {
            public const string UrlPath = "~/Content/fonts";
            public static string Url() { return T4MVCHelpers.ProcessVirtualPath(UrlPath); }
            public static string Url(string fileName) { return T4MVCHelpers.ProcessVirtualPath(UrlPath + "/" + fileName); }
            public static readonly string glyphicons_halflings_regular_eot = Url("glyphicons-halflings-regular.eot");
            public static readonly string glyphicons_halflings_regular_svg = Url("glyphicons-halflings-regular.svg");
            public static readonly string glyphicons_halflings_regular_ttf = Url("glyphicons-halflings-regular.ttf");
            public static readonly string glyphicons_halflings_regular_woff = Url("glyphicons-halflings-regular.woff");
            public static readonly string glyphicons_halflings_regular_woff2 = Url("glyphicons-halflings-regular.woff2");
        }
    
        public static readonly string game_less = Url("game.less");
        public static readonly string game_css = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(UrlPath + "/game.min.css") ? Url("game.min.css") : Url("game.css");
        public static readonly string game_min_css = Url("game.min.css");
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public static class page {
            public const string UrlPath = "~/Content/page";
            public static string Url() { return T4MVCHelpers.ProcessVirtualPath(UrlPath); }
            public static string Url(string fileName) { return T4MVCHelpers.ProcessVirtualPath(UrlPath + "/" + fileName); }
            public static readonly string page_less = Url("page.less");
            public static readonly string page_css = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(UrlPath + "/page.min.css") ? Url("page.min.css") : Url("page.css");
            public static readonly string page_min_css = Url("page.min.css");
        }
    
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public static class themes {
            public const string UrlPath = "~/Content/themes";
            public static string Url() { return T4MVCHelpers.ProcessVirtualPath(UrlPath); }
            public static string Url(string fileName) { return T4MVCHelpers.ProcessVirtualPath(UrlPath + "/" + fileName); }
            [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
            public static class black {
                public const string UrlPath = "~/Content/themes/black";
                public static string Url() { return T4MVCHelpers.ProcessVirtualPath(UrlPath); }
                public static string Url(string fileName) { return T4MVCHelpers.ProcessVirtualPath(UrlPath + "/" + fileName); }
                public static readonly string variables_game_less = Url("variables-game.less");
                public static readonly string variables_game_css = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(UrlPath + "/variables-game.min.css") ? Url("variables-game.min.css") : Url("variables-game.css");
                public static readonly string variables_game_min_css = Url("variables-game.min.css");
                public static readonly string variables_less = Url("variables.less");
                public static readonly string variables_css = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(UrlPath + "/variables.min.css") ? Url("variables.min.css") : Url("variables.css");
                public static readonly string variables_min_css = Url("variables.min.css");
            }
        
        }
    
    }

    
    [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
    public static partial class Bundles
    {
        public static partial class Scripts 
        {
            public static partial class apps 
            {
                public static class Assets
                {
                }
            }
            public static partial class components 
            {
                public static partial class board 
                {
                    public static class Assets
                    {
                    }
                }
                public static partial class common 
                {
                    public static class Assets
                    {
                    }
                }
                public static partial class game 
                {
                    public static class Assets
                    {
                    }
                }
                public static partial class questionnaire 
                {
                    public static class Assets
                    {
                    }
                }
                public static class Assets
                {
                }
            }
            public static partial class page 
            {
                public static class Assets
                {
                }
            }
            public static partial class typings 
            {
                public static partial class angularjs 
                {
                    public static class Assets
                    {
                    }
                }
                public static partial class jquery 
                {
                    public static class Assets
                    {
                    }
                }
                public static class Assets
                {
                }
            }
            public static class Assets
            {
                public const string _references_js = "~/Scripts/_references.js"; 
            }
        }
        public static partial class Content 
        {
            public static partial class bootstrap 
            {
                public static partial class mixins 
                {
                    public static class Assets
                    {
                    }
                }
                public static class Assets
                {
                }
            }
            public static partial class fonts 
            {
                public static class Assets
                {
                }
            }
            public static partial class page 
            {
                public static class Assets
                {
                }
            }
            public static partial class themes 
            {
                public static partial class black 
                {
                    public static class Assets
                    {
                    }
                }
                public static class Assets
                {
                }
            }
            public static class Assets
            {
                public const string bootstrap_css = "~/Content/bootstrap.css";
            }
        }
    }
}

[GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
internal static class T4MVCHelpers {
    // You can change the ProcessVirtualPath method to modify the path that gets returned to the client.
    // e.g. you can prepend a domain, or append a query string:
    //      return "http://localhost" + path + "?foo=bar";
    private static string ProcessVirtualPathDefault(string virtualPath) {
        // The path that comes in starts with ~/ and must first be made absolute
        string path = VirtualPathUtility.ToAbsolute(virtualPath);
        
        // Add your own modifications here before returning the path
        return path;
    }

    // Calling ProcessVirtualPath through delegate to allow it to be replaced for unit testing
    public static Func<string, string> ProcessVirtualPath = ProcessVirtualPathDefault;

    // Calling T4Extension.TimestampString through delegate to allow it to be replaced for unit testing and other purposes
    public static Func<string, string> TimestampString = System.Web.Mvc.T4Extensions.TimestampString;

    // Logic to determine if the app is running in production or dev environment
    public static bool IsProduction() { 
        return (HttpContext.Current != null && !HttpContext.Current.IsDebuggingEnabled); 
    }
}





#endregion T4MVC
#pragma warning restore 1591, 3008, 3009, 0108, 0114


