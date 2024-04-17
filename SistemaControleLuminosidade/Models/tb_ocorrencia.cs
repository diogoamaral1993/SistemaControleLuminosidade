namespace SistemaControleLuminosidade.Models
{
    public class tb_ocorrencia
    {
        public int id { get; set; }
        public string descricao { get; set; }
        public DateTime data_inclusao { get; set; }
        public DateTime? data_fim { get; set; }
        public string status_ocorrencia { get; set; }
    }
}
