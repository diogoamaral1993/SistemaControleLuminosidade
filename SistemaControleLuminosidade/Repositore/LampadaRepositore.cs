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

        public tb_lampada BuscarLampadaPorId(int id_lampada) 
        {
            return context.tb_lampada.FirstOrDefault(l => l.id_lampada == id_lampada);
        }

        public Boolean InformarComoQueimada(tb_lampada lampada) 
        {
            lampada.status_lampada = "Queimado";
            lampada.situacao_lampada = "Desligado";
            lampada.data_fim = DateTime.Now;
            context.tb_lampada.Update(lampada);
            context.SaveChanges();
            return true;
        }

        public void CadastrarLampada(tb_lampada lampada) 
        {
            context.tb_lampada.Add(lampada);
            context.SaveChanges();
        }
    }
}
