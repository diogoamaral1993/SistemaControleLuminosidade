using System.ComponentModel.DataAnnotations;

namespace SistemaControleLuminosidade.Models
{
    public class tb_lampada
    {
        [Key]
        public int id_lampada { get; set; }
        public int id_sensor { get; set; }
        public string nome_lampada { get; set; }
        public DateTime data_inclusao { get; set; }
        public DateTime? data_fim { get; set; }
        public DateTime? data_ultima_atualizacao { get; set; }
        public int? quantidade_vezes_ligacao { get; set; }
        public string situacao_lampada { get; set; }
        public string bloco { get; set; }
        public string status_lampada { get; set; }
    }
}
