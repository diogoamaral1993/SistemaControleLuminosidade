using Microsoft.EntityFrameworkCore;
using SistemaControleLuminosidade.Models;
using System.Data;

namespace SistemaControleLuminosidade.Data
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {

        }

        public DbSet<tb_lampada> tb_lampada { get; set; }
        public DbSet<tb_sensor> tb_sensor { get; set; }
        public DbSet<tb_usuario> tb_usuario { get; set; }
    }
}
