using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace projeto_radar_backend.Models
{
    
    public record PosicoesProduto
    {
        
        public int Id { get; set; } = default!;
        public int CampanhaId { get; set; } = default!;
        public string PosicaoX { get; set; } = default!;
        public string PosicaoY { get; set; } = default!;

        
        public Campanha? Campanha { get; set; }
    }
    }

