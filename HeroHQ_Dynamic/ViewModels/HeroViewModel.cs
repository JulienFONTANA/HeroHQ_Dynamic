using HeroHQ_Dynamic.Model;
using System.Collections.Generic;
using System.Linq;

namespace HeroHQ_Dynamic.ViewModels
{
    // Classe Utilisé dans la page /Hero/Détails
    // Elle permet de chercher les informations relatives à un héro en particulier
    public class HeroDetailsViewModel : ViewModel
    {
        // Ici on n'as besoin que d'un seul héro
        public Hero detail { get; set; }

        public HeroDetailsViewModel()
        {
            // Le constructeur initialise le héro
            detail = new Hero();
        }

        // Cette fonction va chercher le héro donc l'Id correspond
        public void getHeroDetail(int id)
        {
            detail = heros.Find(h => h.Id == id);
        }
    }

    // Classe utilisée dans la page /Hero/Search
    // Elle permet de charcher les héros dont le nom correspond tout ou parti à la recherche
    public class HeroSearchViewModel : ViewModel
    {
        // Ici on peut avoir plusieurs héros, on utilise donc une liste
        public List<Hero> herolist { get; set; }

        public HeroSearchViewModel()
        {
            // Le constructeur initialise la liste de héros
            herolist = new List<Hero>();
        }

        public void getSearchResult(string heroname)
        {
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
             * Cette fonction cherche tout les héros dont le nom en minuscule contient le nom
             * recherché en minuscule puis tri les résultas par ordre alphabétique, et
             * met ces résultats dans une liste!
            */
            herolist = heros.Where(h => h.Nom.ToLower().Contains(heroname.ToLower()))
                            .OrderBy(h => h.Nom)
                            .ToList();
        }
    }
}