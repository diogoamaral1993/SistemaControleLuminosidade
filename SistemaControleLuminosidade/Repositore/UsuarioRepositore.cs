using Microsoft.EntityFrameworkCore;
using SistemaControleLuminosidade.Data;
using SistemaControleLuminosidade.Models;

namespace SistemaControleLuminosidade.Repositore
{
    public class UsuarioRepositore
    {
        ApplicationContext context;

        public UsuarioRepositore()
        {
            var optionsBuilder = new DbContextOptionsBuilder<ApplicationContext>();
            optionsBuilder.UseSqlServer("Server=master1.database.windows.net;Database=master1;Trusted_Connection=True;");
            context = new ApplicationContext(optionsBuilder.Options);
        }

        public tb_usuario FazerLogin(string usuario, string senha) 
        {
            return context.tb_usuario.Where(u => u.usuario == usuario && u.senha == senha).FirstOrDefault();
        }
    }
}
