using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace projeto_radar_backend.Models
{
    [Table("Produto")]
    public partial class Produto
    {
        public Produto()
        {
            PedidosProdutos = new HashSet<PedidosProduto>();
        }

        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("nome")]
        [StringLength(100)]
        public string Nome { get; set; } = null!;
        [Column("descricao")]
        [StringLength(255)]
        public string Descricao { get; set; } = null!;
        [Column("valor")]
        public int Valor { get; set; }
        [Column("QtdEstoque")]
        public int QtdEstoque { get; set; }

        [InverseProperty("Produto")]
        public virtual ICollection<PedidosProduto> PedidosProdutos { get; set; }
    }
}
