using HeroHQ_Dynamic.Models;
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
        // Lien vers la Base de donnée
        // Ce champs est private, seul le Controller peut y acceder.
        private Context bdd;

        // Lorsque l'on utilise le controller, on charge notre base de données grâce au constructeur.
        public HeroController()
        {
            bdd = new Context();
        }

        // Gère l'affichage d'un héros en détail
        #region Détails
        public ActionResult Details(int id)
        {
            // Si id est négatif, c'est une erreur!
            if (id <= 0)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            // Récupération des informations du héro avec son Id
            Hero hero = bdd.Heroes.Where(h => h.Id == id).Single();

            // Test pour vérifier que le héro existe
            if (hero == null)
            {
                return HttpNotFound();
            }

            return View(hero);
        }
        #endregion

        // Gère la recherche de héros
        #region Recherche
        // Si il n'y a pas de paramètre passé, on prends "" comme valeur par défaut.
        // "" étant présent dans tout les noms de héros, on obtiendra la liste de tout les héros.
        public ActionResult Search(string heroName = "")
        {
            /* Cette requète est à la fois compliquée et très simple.
             *  
             * Il s'agit d'une requète Linq, encapsulée dans une fonction Lambda...
             * 
             * Linq est l'accronyme de "Language Integrated Query" est agit comme du SQL
             * pour manipuler une base de données.
             * 
             * Une fonction Lambda est une fonction anonyme, c'est à dire une fonction sans
             * nom donc l'expression est directement passé entre parenthèses.
             * Par exemple: (h => h.Id >= 3) me renvoie les éléménts "h" ayant un Id supérieur
             * ou égal à 3... 
             * 
             * Cette fonction cherche tout les héros dont le nom en minuscule contient le nom
             * recherché en minuscule puis tri les résultas par ordre alphabétique, et
             * met ces résultats dans une liste.
            */
            heroName = heroName.ToLower();

            var heroSearch = bdd.Heroes.Where(h => h.Nom.ToLower().Contains(heroName))
                            .OrderBy(h => h.Nom)
                            .ToList();

            if (heroSearch == null)
            {
                return HttpNotFound();
            }
            return View(heroSearch);
        }
        #endregion

        // Gère l'ajout d'un nouveau héros
        #region Nouveau Héros
        public ActionResult Create()
        {
            return View();
        }

        // POST: /Hero/Create
        // HttpPost est utilisé pour envoyer une information au serveur
        [HttpPost]
        public ActionResult Create(string heroName, int heroAge, string heroPow, string heroCit, string heroImg)
        {
            // Création d'un héro. Noter qu'on ne lui affecte pas d'Id!
            // L'Id est crée automatiquement quand on ajout une entrée à la bdd.
            var newHero = new Hero();
            newHero.Age = heroAge;
            newHero.Citation = heroCit;
            newHero.Nom = heroName;
            newHero.Photo = heroImg;
            newHero.Pouvoir = heroPow;

            // On l'ajoute à la base de données.
            bdd.Heroes.Add(newHero);

            try
            {
                // On essaye de sauvegarder!
                bdd.SaveChanges();
            }
            catch (Exception)
            {
                // Si erreur, on retourne sur la page de création du héro.
                return View();
            }

            // Sinon on retourne sur la page du héros créé.
            int heroID = bdd.Heroes.First(h => h.Nom == heroName).Id;
            return Redirect("/Hero/Details/" + heroID);
        }
        #endregion
    }
}