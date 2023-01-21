using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace projeto_radar_backend.Models
{
  [Table("pedidosprodutos")]
  public record PedidosProduto
  {
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    [Required]
    [Column("pedido_id", TypeName = "int")]
    public int PedidoId { get; set; }

    public Pedido? Pedido { get; set; }

    [Required]
    [Column("produto_id", TypeName = "int")]
    public int ProdutoId { get; set; }

    public Produto? Produto { get; set; }

    [Column("valor", TypeName = "decimal")]
    public decimal? Valor { get; set; }

    [Column("quantidade", TypeName = "int")]
    public int? Quantidade { get; set; }
  }
}
