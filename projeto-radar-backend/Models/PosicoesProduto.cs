using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace projeto_radar_backend.Models
{
  [Table("posicoesprodutos")]
  public record PosicoesProduto
  {
   [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    [Required]
    [Column("campanha_id", TypeName = "int")]
    public int CampanhaId { get; set; } = default!;

    public Campanha Campanha { get; set; } = null!;

    [Required]
    [Column("posicao_x", TypeName ="varchar(20)")]
    public string PosicaoX { get; set; } = default!;

    [Column("posicao_y", TypeName = "varchar(20)")]
    public string PosicaoY { get; set; } = null!;
  }
}
