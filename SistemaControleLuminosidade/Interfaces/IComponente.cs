﻿namespace SistemaControleLuminosidade.Interfaces
{
    public interface IComponente
    {
        public int id { get; set; }
        public string nome { get; set; }
        public string tipo { get; set; }
        public string descricao { get; set; }
        public decimal preco { get; set; }
    }
}
