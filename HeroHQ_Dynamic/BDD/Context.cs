using System.Data.Entity;

namespace HeroHQ_Dynamic.Model
{
    // Classe Context
    // Un "contexte" est comme son nom l'indique l'ensemble des
    // éléments utilisé par votre programme pour fonctionner
    // Plus précisément, un contexte en informatique est souvent
    // utilisé pour faire référance à la base de donnée
    public class Context : DbContext
    {
        // DbSet est une collection qui agit comme une basse de donnée et qui
        // est utilisée par EntityFramework
        public DbSet<Hero> allHeros { get; set; }
    }
}