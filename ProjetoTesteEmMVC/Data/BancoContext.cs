using Microsoft.EntityFrameworkCore;
using ProjetoTesteEmMVC.Models;


namespace ProjetoTesteEmMVC.Data
{
    public class BancoContext : DbContext
    {
        private const string Options = "ConnectionDB";
        public BancoContext(DbContextOptions<BancoContext> options) : base(options)
        {
        }

        public DbSet<PersonagensModel> PersonagensDb { get; set; }
    }
}
