using Microsoft.EntityFrameworkCore;
using projeto_radar_backend.Models;

namespace projeto_radar_backend.Database
{
  public partial class DbRadarContext : DbContext
  {
    public DbRadarContext()
    {
    }

    public DbRadarContext(DbContextOptions<DbRadarContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Campanha> Campanhas { get; set; } = null!;
    public virtual DbSet<Cliente> Clientes { get; set; } = null!;
    public virtual DbSet<LojaDTO> Lojas { get; set; } = null!;
    public virtual DbSet<Pedido> Pedidos { get; set; } = null!;
    public virtual DbSet<PedidosProduto> PedidosProdutos { get; set; } = null!;
    public virtual DbSet<PosicoesProduto> PosicoesProdutos { get; set; } = null!;
    public virtual DbSet<Produto> Produtos { get; set; } = null!;
    public virtual DbSet<User> Users{ get; set; } = null!;
  }
}