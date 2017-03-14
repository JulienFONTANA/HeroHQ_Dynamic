using HeroHQ_Dynamic.Model;
using System.Collections.Generic;
using System.Linq;

namespace HeroHQ_Dynamic.ViewModels
{
    // ViewModel est ma classe mère. Elle seule doit contenir un accès direct à la base de donnée
    public class ViewModel
    {
        // Lien vers la Base de donnée
        // Ce champs est privé, on doit passez par un accesseur (Db) pour y accéder
        // Ce procédé est appelé "encapsulation" et permet plus de sécuritée 
        private Context _db;

        // Liste contenant tout les héros
        public List<Hero> heros { get; set; }

        // Accesseur
        public Context Db
        {
            get { return _db; }
            set { _db = value; }
        }

        public ViewModel()
        {
            // Initialisation de la base de donnée et de la liste de héros
            Db = new Context();
            heros = new List<Hero>();

            // La variable "heros" contients tout les héros de la base de donnée
            // Je peut modifier, agencer ou supprimer ces valeurs sans risque de
            // modifier mes informations sauvegardés
            heros = Db.allHeros.ToList();
        }
    }
}