using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace projeto_radar_backend.Models
{
  [Table("pedidos")]
  public record Pedido
  {
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    [Required]
    [Column("cliente_id")]
    public int ClienteId { get; set; } = default!;

    [Required]
    [Column("cliente", TypeName = "varchar(150)")]
    public Cliente Cliente { get; set; } = default!;

    [Column("valor_total", TypeName = "decimal")]
    public decimal? ValorTotal { get; set; }

    [Required]
    [Column("data", TypeName = "DateTime")]
    public DateTime Data { get; set; } = default!;
  }
}
