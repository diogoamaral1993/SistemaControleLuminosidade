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
            optionsBuilder.UseSqlServer("Server=tcp:master1.database.windows.net,1433;Initial Catalog=master1;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;Authentication=\"Active Directory Default\";");
            context = new ApplicationContext(optionsBuilder.Options);
        }

        public tb_usuario FazerLogin(string usuario, string senha) 
        {
            return context.tb_usuario.Where(u => u.usuario == usuario && u.senha == senha).FirstOrDefault();
        }
    }
}
