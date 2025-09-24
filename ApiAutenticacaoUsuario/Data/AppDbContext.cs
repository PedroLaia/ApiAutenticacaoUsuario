using ApiAutenticacaoUsuario.Models;
using Microsoft.EntityFrameworkCore;

namespace ApiAutenticacaoUsuario.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            
        }

        public DbSet<UsuarioModel> Usuarios { get; set; }


     }
}
