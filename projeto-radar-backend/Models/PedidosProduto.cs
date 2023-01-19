using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace projeto_radar_backend.Models
{
    public record PedidosProduto
    {
        
        public int Id { get; set; } = default!;
        public int PedidoId { get; set; } = default!;
        public int ProdutoId { get; set; } = default!;
        public int Valor { get; set; } = default!;
        public int Quantidade { get; set; }
        public  Pedido? Pedido { get; set; }
        public  Produto? Produto { get; set; }
    }
}
