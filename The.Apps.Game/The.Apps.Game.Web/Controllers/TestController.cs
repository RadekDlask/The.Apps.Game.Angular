using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace The.Apps.Game.Web.Controllers
{
    public partial class TestController : Controller
    {
        // GET: Test
        public virtual ActionResult Index()
        {
            return View();
        }
    }
}