using System.ComponentModel.DataAnnotations;

namespace HeroHQ_Dynamic.Models
{
    // Classe "Hero", elle représente notre modèle dans la base de donnée
    public class Hero
    {
        // [Key] est une annotation pour signaler à EntityFramework
        // que le champ Id est une clé primaire
        [Key]
        public int Id { get; set; }
        public string Nom { get; set; }
        public int Age { get; set; }
        public string Pouvoir { get; set; }
        public string Citation { get; set; }
        public string Photo { get; set; }
    }
}