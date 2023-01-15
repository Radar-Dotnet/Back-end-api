using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace projeto_radar_backend.Models
{
    public partial class Loja
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("nome")]
        [StringLength(100)]
        public string Nome { get; set; } = null!;
        [Column("observacao")]
        [StringLength(255)]
        public string? Observacao { get; set; }
        [Column("cep")]
        [StringLength(15)]
        public string Cep { get; set; } = null!;
        [Column("logradouro")]
        [StringLength(50)]
        public string Logradouro { get; set; } = null!;
        [Column("numero")]
        public int Numero { get; set; }
        [Column("bairro")]
        [StringLength(50)]
        public string Bairro { get; set; } = null!;
        [Column("cidade")]
        [StringLength(45)]
        public string Cidade { get; set; } = null!;
        [Column("estado")]
        [StringLength(2)]
        public string Estado { get; set; } = null!;
        [Column("complemento")]
        [StringLength(45)]
        public string? Complemento { get; set; }
        [Column("latitude")]
        [StringLength(25)]
        public string Latitude { get; set; } = null!;
        [Column("longitude")]
        [StringLength(25)]
        public string Longitude { get; set; } = null!;
    }
}
