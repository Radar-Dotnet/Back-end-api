using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace projeto_radar_backend.Models
{
  [Table("users")]
  public record User
  {
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    [Required]
    [Column("nome", TypeName = "varchar(100)")]
    public string Nome { get; set; } = default!;

    [Required]
    [Column("email", TypeName = "varchar(150)")]
    public string Email { get; set; } = default!;

    [Required]
    [Column("senha", TypeName = "varchar(20)")]
    public string Senha { get; set; } = default!;

    [Required]
    [Column("nivel", TypeName = "varchar(20)")]
    public string Nivel { get; set; } = default!;
  }
}
