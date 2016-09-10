using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace The.Apps.Game.Web.Controllers
{
    public partial class TemplateController : Controller
    {
        // GET: Questionnaire
        public virtual ActionResult Questionnaire()
        {
            return PartialView(MVC.Questionnaire.Views._Questionnaire);
        }
    }
}