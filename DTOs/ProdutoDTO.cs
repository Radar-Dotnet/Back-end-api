using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace projeto_radar_backend.DTOs
{
	public class ProdutoDTO
	{

        public string Nome { get; set; } = null!;
        public string Descricao { get; set; } = null!;
        public decimal Valor { get; set; }
        public int QtdEstoque { get; set; }
    }
}

