using Microsoft.EntityFrameworkCore;
using SistemaControleLuminosidade.Models;
using System.Data;

namespace SistemaControleLuminosidade.Data
{
    public class ApplicationContext : DbContext
    {
        public DbSet<tb_lampada> tb_lampada { get; set; }
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options) 
        { 
        
        }
    }
}
