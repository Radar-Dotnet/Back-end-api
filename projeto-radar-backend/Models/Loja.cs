using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace projeto_radar_backend.Models
{
  [Table("lojas")]
  public record LojaDTO
  {
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    [Required]
    [Column("nome", TypeName = "varchar(150)")]
    public string Nome { get; set; } = default!;

    [Column("observacao", TypeName = "text")]
    public string? Observacao { get; set; }

    [Required]
    [Column("cep", TypeName = "varchar(15)")]
    public string Cep { get; set; } = default!;

    [Required]
    [Column("logradouro", TypeName = "varchar(100)")]
    public string Logradouro { get; set; } = default!;

    [Column("numero", TypeName = "int")]
    public int? Numero { get; set; }

    [Required]
    [Column("bairro", TypeName = "varchar(100)")]
    public string? Bairro { get; set; } = default!;

    [Required]
    [Column("cidade", TypeName = "varchar(50)")]
    public string Cidade { get; set; } = default!;

    [Required]
    [Column("estado", TypeName = "varchar(2)")]
    public string Estado { get; set; } = default!;

    [Column("complemento", TypeName = "varchar(100)")]
    public string? Complemento { get; set; }

    [Required]
    [Column("latitude", TypeName = "varchar(50)")]
    public string Latitude { get; set; } = default!;

    [Required]
    [Column("latitude", TypeName = "varchar(50)")]
    public string Longitude { get; set; } = default!;
  }
}
