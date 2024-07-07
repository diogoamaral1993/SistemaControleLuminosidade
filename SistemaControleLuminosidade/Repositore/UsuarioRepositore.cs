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
            optionsBuilder.UseSqlServer("Data Source=localhost;Initial Catalog=master;Integrated Security=True;TrustServerCertificate=True;");
            //optionsBuilder.UseSqlServer("Server=tcp:servidor-devenvolvimento.database.windows.net,1433;Initial Catalog=BancoSistemaControleLuminosidade;Persist Security Info=False;User ID=diogo.amaral;Password=Ellen@1993;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            context = new ApplicationContext(optionsBuilder.Options);
        }

        public tb_usuario FazerLogin(string usuario, string senha) 
        {
            return context.tb_usuario.Where(u => u.usuario == usuario && u.senha == senha).FirstOrDefault();
        }
    }
}
