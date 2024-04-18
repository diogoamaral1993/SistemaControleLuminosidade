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
            optionsBuilder.UseSqlServer("Data Source=localhost;Initial Catalog=master;Integrated Security=True;TrustServerCertificate=True;");
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
    }
}
