using HeroHQ_Dynamic.Model;
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
        #region Details
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
        #endregion

        #region Recherche
        // GET : /Hero/Search/ <- Page par défaut
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

        // POST: /Hero/Search/{nom du hero}
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
        #endregion

        #region Nouveau Hero
        // GET: /Hero/Create
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        // POST: /Hero/Create
        [HttpPost]
        public ActionResult Create(string heroName, int heroAge, string heroPow, string heroCit, string heroImg)
        {
            var vm = new ViewModel(); // used for the context

            var newHero = new Hero();
            newHero.Age = heroAge;
            newHero.Citation = heroCit;
            //newHero.Id = vm.heros.Count() + 1;
            newHero.Nom = heroName;
            newHero.Photo = heroImg;
            newHero.Pouvoir = heroPow;

            vm.db.allHeros.Add(newHero);

            try
            {
                vm.db.SaveChanges();
            }
            catch (Exception)
            {
                // Si erreur on retourne sur la page de création du héro
                return View();
            }

            // Sinon on retourne sur la page du héro créé
            int heroID = vm.db.allHeros.First(h => h.Nom == heroName).Id;
            return Redirect("/Hero/Details/" + heroID);
        }
        #endregion
    }
}