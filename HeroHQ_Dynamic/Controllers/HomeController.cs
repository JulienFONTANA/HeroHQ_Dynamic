using HeroHQ_Dynamic.ViewModels;
using System.Web.Mvc;

namespace HeroHQ_Dynamic.Controllers
{
    // HomeController est le controller qui s'occupe de l'accueil
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            // Toutes les information affichés à l'accueil son récupérés dans HomeViewModel
            var model = new HomeViewModel();
            return View(model);
        }
    }
}