using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace projeto_radar_backend.Models
{
  [Table("clientes")]
  [Index("Cpf", Name = "cpf_UNIQUE", IsUnique = true)]
  [Index("Email", Name = "email_UNIQUE", IsUnique = true)]
  public record Cliente
  {
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    [Required]
    [Column("nome", TypeName = "varchar(150)")]
    public string Nome { get; set; } = default!;

    [Required]
    [Column("telefone", TypeName = "varchar(15)")]
    public string Telefone { get; set; } = default!;

    [Required]
    [Column("email", TypeName = "varchar(150)")]
    public string Email { get; set; } = default!;

    [Required]
    [Column("cpf", TypeName = "varchar(15)")]
    public string Cpf { get; set; } = default!;

    [Required]
    [Column("cep", TypeName = "varchar(15)")]
    public string Cep { get; set; } = default!;

    [Required]
    [Column("logradouro", TypeName = "varchar(100)")]
    public string? Logradouro { get; set; } = default!;

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

  }
}
