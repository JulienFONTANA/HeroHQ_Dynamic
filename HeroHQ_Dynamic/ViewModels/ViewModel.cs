using HeroHQ_Dynamic.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HeroHQ_Dynamic.ViewModels
{
    public class ViewModel
    {
        private Context db { get; }
        public List<Hero> heros { get; set; }

        public ViewModel()
        {
            db = new Context();
            heros = new List<Hero>();
            heros = db.allHeros.ToList();
        }
    }
}