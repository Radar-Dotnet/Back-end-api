using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace projeto_radar_backend.Models
{
    [Index("CampanhaId", Name = "fk_PosicoesProdutos_Campanhas1_idx")]
    public partial class PosicoesProduto
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("campanha_id")]
        public int CampanhaId { get; set; }
        [Column("posicao_x")]
        [StringLength(45)]
        public string PosicaoX { get; set; } = null!;
        [Column("posicao_y")]
        [StringLength(45)]
        public string PosicaoY { get; set; } = null!;

        [ForeignKey("CampanhaId")]
        [InverseProperty("PosicoesProdutos")]
        public virtual Campanha Campanha { get; set; } = null!;
    }
}
