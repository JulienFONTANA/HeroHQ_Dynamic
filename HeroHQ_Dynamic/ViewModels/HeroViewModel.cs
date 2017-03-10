using HeroHQ_Dynamic.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HeroHQ_Dynamic.ViewModels
{
    public class HeroDetailsViewModel : ViewModel
    {
        public Hero detail { get; set; }

        public HeroDetailsViewModel()
        {
            detail = new Hero();
        }

        public void getHeroDetail(int id)
        {
            detail = heros.Find(h => h.Id == id);
        }
    }


    public class HeroSearchViewModel : ViewModel
    {
        public List<Hero> herolist { get; set; }

        public HeroSearchViewModel()
        {
            herolist = new List<Hero>();
        }

        public void getSearchResult(string heroname)
        {
            herolist = heros.Where(h => h.Nom.ToLower().Contains(heroname.ToLower())).ToList();
        }
    }
}