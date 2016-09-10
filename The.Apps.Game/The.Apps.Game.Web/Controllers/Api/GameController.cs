using System.Web.Http;
using The.Apps.Game.Web.ViewModels.GameViewModels.GamePlay;

namespace The.Apps.Game.Web.Controllers.Api
{
    public class GameController : ApiController
    {
        [HttpGet]
        public GameMainViewModel Play(int id)
        {
            if (id < 1)
            {
                throw new HttpResponseException(System.Net.HttpStatusCode.NotFound);
            }
            return new GameMainViewModel { Id = id, Name = "Game " + id};
        }
    }
}
