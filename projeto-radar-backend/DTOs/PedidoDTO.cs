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
        public int ValorTotal { get; set; }
        public DateTime Data { get; set; }
        public Cliente Cliente { get; set; } = null!;
    }
}

