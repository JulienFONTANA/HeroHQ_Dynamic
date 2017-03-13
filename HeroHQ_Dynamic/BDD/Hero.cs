using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace HeroHQ_Dynamic.Model
{
    public class Hero
    {
        [Key]
        public int Id { get; set; }
        public string Nom { get; set; }
        public int Age { get; set; }
        public string Pouvoir { get; set; }
        public string Citation { get; set; }
        public string Photo { get; set; }

        public Hero()
        {

        }

        public Hero(string nom, int age, string pouvoir, string citation, string photo)
        {
            Nom = nom;
            Age = age;
            Pouvoir = pouvoir;
            Citation = citation;
            Photo = photo;
        }
    }
}