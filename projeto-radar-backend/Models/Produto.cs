using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace projeto_radar_backend.Models
{
    public record Produto
    { 
        public int Id { get; set; } = default!;
        public string Nome { get; set; } = default!;
        public string Descricao { get; set; } = default!;
        public int Valor { get; set; } = default!;
        public int QtdEstoque { get; set; } = default!;
    }
}
