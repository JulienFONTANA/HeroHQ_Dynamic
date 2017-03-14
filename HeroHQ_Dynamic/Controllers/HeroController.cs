using HeroHQ_Dynamic.Model;
using HeroHQ_Dynamic.ViewModels;
using System;
using System.Linq;
using System.Net;
using System.Web.Mvc;

namespace HeroHQ_Dynamic.Controllers
{
    // HeroController gère toutes les pages du site (sauf l'accueil)
    // Ce controller gère l'affichage des héros sur les pages de recherche et
    // en détails, ainsi que la création de ces derniers
    public class HeroController : Controller
    {
        // Gère l'affichage d'un héro en détail
        #region Details
        // GET: Hero/Details/{id du héro}
        [HttpGet]
        public ActionResult Details(int id)
        {
            // Si id est négatif, c'est une erreur!
            if (id <= 0)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            // Génération de HeroDetailsViewModel et récupération des informations du héro avec son Id
            var heroDWM = new HeroDetailsViewModel();
            heroDWM.getHeroDetail(id);

            // Test pour vérifier que le héro existe
            if (heroDWM.detail == null)
            {
                return HttpNotFound();
            }

            return View(heroDWM);
        }
        #endregion

        // Gère la recherche de héro
        #region Recherche
        // GET : /Hero/Search/ <- Page par défaut
        [HttpGet]
        public ActionResult Search()
        {
            var heroSearch = new HeroSearchViewModel();

            // Ici la recherche est effectuée sur le caractère "", présent dans tout les nom de héros
            // On les affichent donc tous!
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
            // Vérification sur le paramètre reçu, pour qu'il ne soit pas "null"
            if (heroName != null)
            {
                var heroSearch = new HeroSearchViewModel();

                // Recherche par nom
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
        // HttpGet est utilisé pour récupérer la vue "vide"
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        // POST: /Hero/Create
        // HttpPost est utilisé pour envoyer une information au serveur
        [HttpPost]
        public ActionResult Create(string heroName, int heroAge, string heroPow, string heroCit, string heroImg)
        {
            var vm = new ViewModel(); // used for the context

            // Création d'un héro. Noter qu'on ne lui affecte pas d'Id!
            var newHero = new Hero();
            newHero.Age = heroAge;
            newHero.Citation = heroCit;
            newHero.Nom = heroName;
            newHero.Photo = heroImg;
            newHero.Pouvoir = heroPow;

            // On l'ajoute à la base de donnée
            vm.Db.allHeros.Add(newHero);

            try
            {
                // On essaye de sauvegarder!
                vm.Db.SaveChanges();
            }
            catch (Exception)
            {
                // Si erreur on retourne sur la page de création du héro
                return View();
            }

            // Sinon on retourne sur la page du héro créé
            int heroID = vm.Db.allHeros.First(h => h.Nom == heroName).Id;
            return Redirect("/Hero/Details/" + heroID);
        }
        #endregion
    }
}