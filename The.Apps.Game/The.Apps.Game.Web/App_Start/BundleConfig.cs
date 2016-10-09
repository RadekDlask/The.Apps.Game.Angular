using System.Web;
using System.Web.Optimization;

namespace The.Apps.Game.Web
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js",
                        "~/Scripts/page/page.js"));            
            
            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/page/page.css"));

            // This is the style bundle used for angular game apps.
            bundles.Add(new StyleBundle("~/Content/game/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/game.css"));

            bundles.Add(new StyleBundle("~/Content/game/css-black").Include(
                      "~/Content/bootstrap/bootstrap-black.css",
                      "~/Content/game.css"));

            // This is the script bundle used for angular game apps.
            var angularScriptBundle = new ScriptBundle("~/bundles/angular").Include(
                "~/Scripts/jquery-{version}.js",
                "~/Scripts/angular.js",

                "~/Scripts/apps/apps-game.js",                

                "~/Scripts/components/common/services-logging.js",
                "~/Scripts/components/common/services-url.js",

                "~/Scripts/components/game/services-game-model.js",
                "~/Scripts/components/game/model-game.js",
                "~/Scripts/components/game/controllers-game.js",
                "~/Scripts/components/game/services-game.js",                

                "~/Scripts/components/questionnaire/models-questionnaire.js",
                "~/Scripts/components/questionnaire/controllers-questionnaire.js",
                "~/Scripts/components/questionnaire/directives-questionnaire.js",
                "~/Scripts/components/questionnaire/services-questionnaire.js",

                "~/Scripts/components/board/models-board.js",
                "~/Scripts/components/board/controllers-board.js",
                "~/Scripts/components/board/directives-board.js",
                "~/Scripts/components/board/services-board.js",

                "~/Scripts/apps/bootstrappers-game.js");

            angularScriptBundle.Transforms.Clear();
            bundles.Add(angularScriptBundle);
        }
    }
}
