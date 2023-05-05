using Exo.WebApi.Models;
using Microsoft.EntityFrameworkCore;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;

namespace Exo.WebApi.Contexts
{
    public class ExoContext : DbContext
    {
        public ExoContext()
        {
        }
        public ExoContext(DbContextOptions<ExoContext> options) : base(options)
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if  (!optionsBuilder.IsConfigured)
            {
                // Essa string de conexão foi depende da SUA máquina.
                optionsBuilder.UseSqlServer("User Id=sa;Password=1207;" +
                                            "Server=localhost\\SQLEXPRESS;" +
                                            "Database=ExoApi;" +
                                            "Trusted_Connection=False;");
            }
        }
        public DbSet<Projeto> Projetos { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
    }
}