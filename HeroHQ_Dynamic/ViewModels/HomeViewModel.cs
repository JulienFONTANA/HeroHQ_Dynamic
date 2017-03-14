using HeroHQ_Dynamic.Model;
using System.Collections.Generic;
using System.Linq;

namespace HeroHQ_Dynamic.ViewModels
{
    // Cette classe contient toutes les information que l'on veut afficher sur l'accueil
    public class HomeViewModel : ViewModel
    {
        // Ici on a besoin d'une liste de héros.
        public List<Hero> herosDispo { get; set; }

        public HomeViewModel()
        {
            // On initialise la liste dans le constructeur
            herosDispo = new List<Hero>();

            /* Cette requète est à la fois compliquée et très simple.
             *  
             * Il s'agit d'une requète Linq, encapsulée dans une fonction Lambda...
             * 
             * Linq est l'accronyme de "Language Integrated Query" est agit comme du SQL
             * 
             * Une fonction Lambda est une fonction anonyme, c'est à dire une fonction sans
             * nom donc l'expression est directement passé entre parenthèses
             * Par exemple: (h => h.Id >= 3) me renvoie les éléménts "h" ayant un Id supérieur
             * ou égal à 3... 
             * 
             * Cette fonction cherche les héros dont l'age est supérieur à 35
             * (pourquoi pas), sélectionne les 8 premiers, et met les résultats dans ma liste
            */
            herosDispo = heros.Where(h => h.Age > 35)
                              .Take(8)
                              .ToList();
        }
    }
}