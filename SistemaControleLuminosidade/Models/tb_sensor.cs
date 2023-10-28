using System.ComponentModel.DataAnnotations;

namespace SistemaControleLuminosidade.Models
{
    public class tb_sensor
    {
        [Key]
        public int id_sensor { get; set; }
        public string nome_sensor { get; set; }
        public DateTime data_inclusao { get; set; }
        public DateTime? data_fim { get; set; }
        public string tipo_sensor { get; set; }
        public string status_sensor { get; set; }
    }
}
