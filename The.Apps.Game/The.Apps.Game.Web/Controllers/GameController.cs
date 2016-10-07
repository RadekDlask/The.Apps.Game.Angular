using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using The.Apps.Game.Core.Services.Abstract;
using The.Apps.Game.Web.ViewModels.GameViewModels;

namespace The.Apps.Game.Web.Controllers
{
    public partial class GameController : Controller
    {
        private IGameService _gameService;

        public GameController(IGameService gameService)
        {
            _gameService = gameService;
        }
        protected override void OnActionExecuting(ActionExecutingContext filterContext)
        {            
            if (filterContext.HttpContext.Request.Cookies.AllKeys.Contains("theme"))
            {
                var theme = filterContext.HttpContext.Request.Cookies["theme"].Value;
                ViewBag.theme = theme;
            }
        }
        // POST: SetTheme
        [HttpPost]
        public virtual ActionResult SetTheme(string theme)
        {
            ControllerContext.HttpContext.Response.Cookies.Add(new HttpCookie("theme", theme));
            return new HttpStatusCodeResult(HttpStatusCode.OK);
        }

        // GET: Index
        public virtual ActionResult Index()
        {
            return View(MVC.Game.Views.Index, new GameIndexViewModel(_gameService.GetListOfGames()));
        }

        // GET: Description
        public virtual ActionResult Description(int gameId)
        {
            return View(MVC.Game.Views.Description, new GameDescriptionViewModel(_gameService.GetGame(gameId)));
        }

        // GET: Game
        public virtual ActionResult Play(int gameId)
        {
            return View(MVC.Game.Views.Play);
        }
    }
}