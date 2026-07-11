using Microsoft.EntityFrameworkCore;
using Projeto_Conexao_MYSQL.Models;

namespace Projeto_Conexao_MYSQL.Data
{
    public class AppDbContext : DbContext
    {
        
            public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
            {
            }

            public DbSet<Produto> Produtos {get; set; }
        
    }
}