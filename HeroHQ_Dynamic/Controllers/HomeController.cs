using HeroHQ_Dynamic.Models;
using System.Linq;
using System.Web.Mvc;

namespace HeroHQ_Dynamic.Controllers
{
    // HomeController est le controller qui s'occupe de l'accueil
    public class HomeController : Controller
    {
        // Lien vers la Base de donnée
        // Ce champs est private, seul le Controller peut y acceder.
        private Context bdd;

        // Lorsque l'on utilise le controller, on charge notre base de données grâce au constructeur.
        public HomeController()
        {
            bdd = new Context();
        }

        public ActionResult Index()
        {
            /* Les informations que nous voulons afficher à l'accueil est une liste de héros.
             * Pour cela, nous allons récuperer certains héros dans la base de données.
             * Cette requète est à la fois compliquée et très simple.
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
             * Cette fonction cherche les héros dont l'age est supérieur à 35,
             * sélectionne les 8 premiers, et met les résultats dans ma liste.
            */
            var herosDispo = bdd.Heroes.Where(h => h.Age > 35)
                               .Take(8)
                               .ToList();

            // Le Controller retourne à la View herosDispo pour qu'elle puisse l'afficher.
            return View(herosDispo);
        }
    }
}