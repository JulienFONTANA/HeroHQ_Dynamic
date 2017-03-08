using HeroHQ_Dynamic.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HeroHQ_Dynamic.ViewModels
{
    public class HomeViewModel : ViewModel
    {
        public List<Hero> herosDispo { get; set; }

        public HomeViewModel()
        {
            herosDispo = new List<Hero>();
            herosDispo = heros.Where(h => h.Age > 35).Take(4).ToList();
        }
    }
}