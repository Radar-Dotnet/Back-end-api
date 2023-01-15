using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace projeto_radar_backend.Models
{
    [Table("Cliente")]
    [Index("Cpf", Name = "cpf_UNIQUE", IsUnique = true)]
    [Index("Email", Name = "email_UNIQUE", IsUnique = true)]
    public partial class Cliente
    {
        public Cliente()
        {
            Pedidos = new HashSet<Pedido>();
        }

        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("nome")]
        [StringLength(100)]
        public string Nome { get; set; } = null!;
        [Column("telefone")]
        [StringLength(15)]
        public string Telefone { get; set; } = null!;
        [Column("email")]
        [StringLength(150)]
        public string Email { get; set; } = null!;
        [Column("cpf")]
        [StringLength(15)]
        public string Cpf { get; set; } = null!;
        [Column("cep")]
        [StringLength(15)]
        public string Cep { get; set; } = null!;
        [Column("logradouro")]
        [StringLength(45)]
        public string Logradouro { get; set; } = null!;
        [Column("numero")]
        public int Numero { get; set; }
        [Column("bairro")]
        [StringLength(45)]
        public string Bairro { get; set; } = null!;
        [Column("cidade")]
        [StringLength(45)]
        public string Cidade { get; set; } = null!;
        [Column("estado")]
        [StringLength(2)]
        public string Estado { get; set; } = null!;
        [Column("complemento")]
        [StringLength(50)]
        public string? Complemento { get; set; }

        [InverseProperty("Cliente")]
        public virtual ICollection<Pedido> Pedidos { get; set; }
    }
}
