using Microsoft.EntityFrameworkCore;
using SistemaControleLuminosidade.Data;
using SistemaControleLuminosidade.Models;

namespace SistemaControleLuminosidade.Repositore
{
    public class LampadaRepositore
    {
        ApplicationContext context;
        public LampadaRepositore()
        {
            var optionsBuilder = new DbContextOptionsBuilder<ApplicationContext>();
            optionsBuilder.UseSqlServer("Data Source=localhost;Initial Catalog=master;Integrated Security=True;TrustServerCertificate=True;");
            context = new ApplicationContext(optionsBuilder.Options);
        }

        public List<tb_lampada> BuscarLampadas() 
        {
            return context.tb_lampada.ToList();
        }
    }
}
