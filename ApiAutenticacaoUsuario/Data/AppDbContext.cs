using Microsoft.EntityFrameworkCore;

namespace ApiAutenticacaoUsuario.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            
        }

    }
}
