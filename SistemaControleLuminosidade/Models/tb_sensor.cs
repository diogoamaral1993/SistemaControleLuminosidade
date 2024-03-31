using SistemaControleLuminosidade.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace SistemaControleLuminosidade.Models
{
    public class tb_sensor : IComponente
    {
        [Key]
        public int id { get; set; }
        public string nome { get; set; }
        public DateTime data_inclusao { get; set; }
        public DateTime? data_fim { get; set; }
        public string tipo_sensor { get; set; }
        public string bloco { get; set; }
        public string status_sensor { get; set; }
    }
}
