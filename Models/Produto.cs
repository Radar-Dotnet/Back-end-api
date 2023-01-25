using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace projeto_radar_backend.Models
{
  [Table("produtos")]
  public record Produto
  {
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    [Required]
    [Column("nome", TypeName = "varchar(150)")]
    public string Nome { get; set; } = default!;

    [Column("descricao", TypeName = "text")]
    public string Descricao { get; set; } = null!;

    [Column("valor", TypeName = "decimal")]
    public decimal? Valor { get; set; }
    
    [Column("qtd_estoque", TypeName = "int")]
    public int QtdEstoque { get; set; }
  }
}
