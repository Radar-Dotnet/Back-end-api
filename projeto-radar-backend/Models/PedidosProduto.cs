using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace projeto_radar_backend.Models
{
    //[Index("PedidoId", Name = "fk_Pedido_has_Produto_Pedido1_idx")]
    //[Index("ProdutoId", Name = "fk_Pedido_has_Produto_Produto1_idx")]
    public record PedidosProduto
    {
        //[Key]
        //[Column("id")]
        public int Id { get; set; }
        //[Column("pedido_id")]
        public int PedidoId { get; set; }

        public Pedido? Pedido { get; set; }
        //[Column("produto_id")]
        public int ProdutoId { get; set; }

        public Produto? Produto { get; set; }

        //[Column("valor")]
        public int Valor { get; set; }
        //[Column("quantidade")]
        public int Quantidade { get; set; }

        //[ForeignKey("PedidoId")]
        //[InverseProperty("PedidosProdutos")]
        //public virtual Pedido Pedido { get; set; } = null!;
        //[ForeignKey("ProdutoId")]
        //[InverseProperty("PedidosProdutos")]
        //public virtual Produto Produto { get; set; } = null!;
    }
}
