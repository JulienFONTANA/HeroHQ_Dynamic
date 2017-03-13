using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace HeroHQ_Dynamic.Model
{
    public class Context : DbContext
    {
        public DbSet<Hero> allHeros { get; set; }
    }
}