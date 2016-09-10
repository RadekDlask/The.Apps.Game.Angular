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