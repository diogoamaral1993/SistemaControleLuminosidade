using Microsoft.EntityFrameworkCore;
using SistemaControleLuminosidade.Data;
using SistemaControleLuminosidade.Models;

namespace SistemaControleLuminosidade.Repositore
{
    public class LampadaRepositore
    {
        ApplicationContext Context;
        public LampadaRepositore()
        {
            var optionsBuilder = new DbContextOptionsBuilder<ApplicationContext>();
            optionsBuilder.UseSqlServer("StringConnection");
            var Context = new ApplicationContext(optionsBuilder.Options);
        }

        public List<tb_lampada> BuscarLampadas() 
        {
            return Context.tb_lampada.ToList();
        }
    }
}
