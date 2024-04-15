using Microsoft.EntityFrameworkCore;
using SistemaControleLuminosidade.Data;

namespace SistemaControleLuminosidade.Repositore
{
    public class UsuarioRepositore
    {
        ApplicationContext context;

        public UsuarioRepositore()
        {
            var optionsBuilder = new DbContextOptionsBuilder<ApplicationContext>();
            optionsBuilder.UseSqlServer("Data Source=localhost;Initial Catalog=master;Integrated Security=True;TrustServerCertificate=True;");
            context = new ApplicationContext(optionsBuilder.Options);
        }

        public Boolean FazerLogin(string usuario, string senha) 
        { 
            Boolean usuarioExiste = ((context.tb_usuario.Where(u => u.usuario == usuario && u.senha == senha).ToList()).Count() == 1);
            return usuarioExiste;
        }
    }
}
