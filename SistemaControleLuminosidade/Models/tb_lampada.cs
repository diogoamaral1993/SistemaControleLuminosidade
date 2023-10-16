namespace SistemaControleLuminosidade.Models
{
    public class tb_lampada
    {
        public int id_lampada { get; set; }
        public string nome_lampada { get; set; }
        public string Status { get; set; }
        public DateTime DataUltimaAtualizacao { get; set; }
    }
}
