using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace projeto_radar_backend.Models
{
    public partial class Campanha
    {
        public Campanha()
        {
            PosicoesProdutos = new HashSet<PosicoesProduto>();
        }

        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("nome")]
        [StringLength(45)]
        public string Nome { get; set; } = null!;
        [Column("descricao")]
        [StringLength(255)]
        public string? Descricao { get; set; }
        [Column("data", TypeName = "datetime")]
        public DateTime Data { get; set; }
        [Column("url_foto_prateleira")]
        [StringLength(255)]
        public string UrlFotoPrateleira { get; set; } = null!;

        [InverseProperty("Campanha")]
        public virtual ICollection<PosicoesProduto> PosicoesProdutos { get; set; }
    }
}
