//using Microsoft.EntityFrameworkCore;
//using projeto_radar_backend.Models;

//namespace projeto_radar_backend.Repository.Entity
//{
//  public class Context : DbContext
//  {
//    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//    {
//      var connection = Environment.GetEnvironmentVariable("DATABASE_CF_URL");
//      if (connection is null) connection = "Server=localhost;Database=DbRadar;Uid=root;Pwd=root;";
//      optionsBuilder.UseMySql(connection, ServerVersion.AutoDetect(connection));
//    }

//    public DbSet<Campanha> Campanhas { get; set; } = default!;
//    public DbSet<Cliente> Clientes { get; set; } = default!;
//    public DbSet<Loja> Lojas { get; set; } = default!;
//    public DbSet<Pedido> Pedidos { get; set; } = default!;
//    public DbSet<PedidosProduto> PedidosProdutos { get; set; } = default!;
//    public DbSet<PosicoesProduto> PosicoesProdutos { get; set; } = default!;
//    public DbSet<Produto> Produtos { get; set; } = default!;
//    public DbSet<User> Users { get; set; } = default!;
//  }
//}