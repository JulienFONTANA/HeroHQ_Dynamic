using HeroHQ_Dynamic.ViewModels;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace HeroHQ_Dynamic.Controllers
{
    public class HeroController : Controller
    {
        // GET: Hero/Details/{id du héro}
        [HttpGet]
        public ActionResult Details(int id)
        {
            if (id <= 0)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            var heroDWM = new HeroDetailsViewModel();
            heroDWM.getHeroDetail(id);
            if (heroDWM.detail == null)
            {
                return HttpNotFound();
            }

            return View(heroDWM);
        }

        [HttpGet]
        public ActionResult Search()
        {
            var heroSearch = new HeroSearchViewModel();

            heroSearch.getSearchResult("");
            if (heroSearch.herolist == null)
            {
                return HttpNotFound();
            }
            return View(heroSearch);
        }

        // POST: Hero/Search/{nom du hero}
        [HttpPost]
        public ActionResult Search(string heroName)
        {
            if (heroName != null)
            {
                var heroSearch = new HeroSearchViewModel();

                heroSearch.getSearchResult(heroName);
                if (heroSearch.herolist == null)
                {
                    return HttpNotFound();
                }
                return View(heroSearch);
            }
            return View();
        }

        //// GET: Receipe/Create
        //[HttpGet]
        //[Authorize]
        //public ActionResult Create()
        //{
        //    return View(createView);
        //}

        //// POST: Receipe/Create
        //[HttpPost]
        //[Authorize]
        ////[ValidateAntiForgeryToken]
        //public ActionResult Create(CreateReceipe cr)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        var recettes = new Recettes();

        //        HttpCookie authCookie = Request.Cookies[FormsAuthentication.FormsCookieName];
        //        recettes.creatorId = Convert.ToInt32(FormsAuthentication.Decrypt(authCookie.Value).Name);

        //        recettes.id = cr.recName.ToLower().Replace(" ", "-");
        //        recettes.name = cr.recName;

        //        recettes.ingredients = new List<Ingredients>();
        //        foreach (var item in cr.recIdIngredients.Split(','))
        //        {
        //            recettes.ingredients.Add(cr.db.Ingredients.SingleOrDefault(m => m.id == item));
        //        }

        //        recettes.calories = cr.recCalories;
        //        recettes.isAvailable = true;

        //        HttpPostedFileBase file = cr.pictureFile;
        //        if (file.ContentLength > 0)
        //        {
        //            string uploadDir = "~/Content/img/recettes/";
        //            string path = Path.Combine(Server.MapPath(uploadDir), file.FileName);
        //            file.SaveAs(path);
        //            recettes.picture = "img/recettes/" + Path.GetFileName(file.FileName);
        //        }

        //        recettes.preparation = cr.recPrep;

        //        cr.db.Recettes.Add(recettes);
        //        cr.db.SaveChanges();
        //        return Redirect("/Community/Details/" + recettes.creatorId);
        //    }
        //    return View(cr);
        //}
    }
}