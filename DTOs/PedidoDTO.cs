using System;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using projeto_radar_backend.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace projeto_radar_backend.DTOs
{
	public class PedidoDTO
	{
        public int Id { get; set; }
        public int ClienteId { get; set; }
        public decimal ValorTotal { get; set; }
        public DateTime Data { get; set; }
        public string NomeCliente { get; set; } = null!;
    }
}

