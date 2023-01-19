using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace projeto_radar_backend.Models
{
    //[Table("Pedido")]
    //[Index("ClienteId", Name = "fk_Pedido_Cliente_idx")]
    public record  Pedido
    {
        //public Pedido()
        //{
        //    PedidosProdutos = new HashSet<PedidosProduto>();
        //}

        //[Key]
        //[Column("id")]
        public int Id { get; set; }
        //[Column("cliente_id")]
        public int ClienteId { get; set; } = default!;

        public Cliente? Cliente { get; set; }
        //[Column("valor_total")]
        public int ValorTotal { get; set; }
        //[Column("data", TypeName = "datetime")]
        public DateTime Data { get; set; }

        //[ForeignKey("ClienteId")]
        //[InverseProperty("Pedidos")]
        //[InverseProperty("Pedido")]
        //public virtual ICollection<PedidosProduto> PedidosProdutos { get; set; }
    }
}
