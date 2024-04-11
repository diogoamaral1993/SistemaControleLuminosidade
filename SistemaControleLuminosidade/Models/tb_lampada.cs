using SistemaControleLuminosidade.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace SistemaControleLuminosidade.Models
{
    public class tb_lampada : IComponente
    {
        [Key]
        public int id { get; set; }
        public int? id_sensor { get; set; }
        public string nome { get; set; }
        public string descricao { get; set; }
        public decimal preco { get; set; }
        public DateTime data_inclusao { get; set; }
        public DateTime? data_fim { get; set; }
        public DateTime? data_ultima_atualizacao { get; set; }
        public int? quantidade_vezes_ligacao { get; set; }
        public string situacao_lampada { get; set; }
        public string? bloco { get; set; }
        public string tipo { get; set; }
        public string status_lampada { get; set; }
    }
}
