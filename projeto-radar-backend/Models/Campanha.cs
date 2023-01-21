using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace projeto_radar_backend.Models
{
  [Table("campanhas")]
  public record Campanha
  {

    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    [Required]
    [Column("nome", TypeName = "varchar(150)")]
    public string Nome { get; set; } = default!;

    [Column("descricao", TypeName = "text")]
    public string? Descricao { get; set; }

    [Column("data", TypeName = "DateTime")]
    public DateTime? Data { get; set; }

    [Column("url_imagem", TypeName = "text")]
    public string? UrlFotoPrateleira { get; set; }

  }
}
