using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace HeroHQ_Dynamic.Model
{
    public class Context : DbContext
    {
        //private string connString { get; }

        //public Context()
        //{
        //    connString = "Data Source=(localdb)/MSSQLLocalDB;Initial Catalog=BDD_Hero;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        //}

        public DbSet<Hero> allHeros { get; set; }
    }
}