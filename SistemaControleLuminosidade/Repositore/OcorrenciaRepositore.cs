using Microsoft.EntityFrameworkCore;
using SistemaControleLuminosidade.Data;
using SistemaControleLuminosidade.Models;

namespace SistemaControleLuminosidade.Repositore
{
    public class OcorrenciaRepositore
    {
        ApplicationContext context;

        public OcorrenciaRepositore()
        {
            var optionsBuilder = new DbContextOptionsBuilder<ApplicationContext>();
            optionsBuilder.UseSqlServer("Data Source=master1.database.windows.net;Initial Catalog=master1; Authentication=Active Directory Default; Encrypt=True;");
            context = new ApplicationContext(optionsBuilder.Options);
        }

        public List<tb_ocorrencia> BuscarOcorrencias()
        {
            return context.tb_ocorrencia.ToList();
        }

        public void CadastrarOcorrencia(tb_ocorrencia correncia)
        {
            context.tb_ocorrencia.Add(correncia);
            context.SaveChanges();
        }

        public tb_ocorrencia BuscarOcorrenciaPorId(int id_ocorrencia)
        {
            return context.tb_ocorrencia.FirstOrDefault(l => l.id == id_ocorrencia);
        }

        public void FinalizarOcorrencia(tb_ocorrencia ocorrencia)
        {
            ocorrencia.status_ocorrencia = "Fechada";
            ocorrencia.data_fim = DateTime.Now;
            context.tb_ocorrencia.Update(ocorrencia);
            context.SaveChanges();
        }
    }
}
