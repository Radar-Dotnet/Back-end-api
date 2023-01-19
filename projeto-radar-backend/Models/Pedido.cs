using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace projeto_radar_backend.Models
{
    public record Pedido
    {
        public int Id { get; set; } = default!;
        public int ClienteId { get; set; } = default!;
        public Cliente? Cliente { get; set; }

        public int ValorTotal { get; set; } = default!;
        public DateTime Data { get; set; } = default!;
    }
}
