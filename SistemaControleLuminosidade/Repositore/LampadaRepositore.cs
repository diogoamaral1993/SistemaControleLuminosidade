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
            optionsBuilder.UseSqlServer("Server=master1.database.windows.net;Authentication=Active Directory Integrated;Database=master1;");
            context = new ApplicationContext(optionsBuilder.Options);
        }

        public List<tb_lampada> BuscarLampadasEstoque() 
        {
            return context.tb_lampada.Where(l => l.status_lampada == "No estoque").ToList();
        }

        public List<tb_lampada> BuscarLampadas()
        {
            return context.tb_lampada.Where(l => l.status_lampada != "No estoque").ToList();
        }

        public tb_lampada BuscarLampadaPorId(int id_lampada) 
        {
            return context.tb_lampada.FirstOrDefault(l => l.id == id_lampada);
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

        public void TirarLmapadaEstoque(int id_lampada, int id_sensor, string bloco) 
        {
            var lampada = context.tb_lampada.FirstOrDefault(l => l.id == id_lampada);
            lampada.status_lampada = "Funcionando";
            lampada.situacao_lampada = "Desligado";
            lampada.quantidade_vezes_ligacao = 0;
            lampada.bloco = bloco;
            lampada.id_sensor = id_sensor;
            context.Update(lampada);
            context.SaveChanges();
        }

        public void AtualizarLampadaEstoque(tb_lampada lampada, string nome) 
        {
            lampada.nome = nome;
            context.Update(lampada);
            context.SaveChanges();
        }
    }
}
