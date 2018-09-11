using System.Data.Entity;

namespace AppCgvf.Models
{
    public class PessoasContext : DbContext
    {
        public DbSet<Pessoas> Pessoas { get; set; }
    }
}