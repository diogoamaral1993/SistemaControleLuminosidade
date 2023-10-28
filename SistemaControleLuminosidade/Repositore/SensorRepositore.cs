using Microsoft.EntityFrameworkCore;
using SistemaControleLuminosidade.Data;
using SistemaControleLuminosidade.Models;
using System.Collections.Generic;

namespace SistemaControleLuminosidade.Repositore
{
    public class SensorRepositore
    {
        ApplicationContext context;
        public SensorRepositore()
        {
            var optionsBuilder = new DbContextOptionsBuilder<ApplicationContext>();
            optionsBuilder.UseSqlServer("Data Source=localhost;Initial Catalog=master;Integrated Security=True;TrustServerCertificate=True;");
            context = new ApplicationContext(optionsBuilder.Options);
        }
        public List<tb_sensor> BuscarSensoresFuncionando()
        {
            return context.tb_sensor.Where(s => s.tipo_sensor == "Luz" && s.status_sensor == "Funcionando").ToList();
        }
    }
}
