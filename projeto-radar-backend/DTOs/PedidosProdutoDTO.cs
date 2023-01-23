namespace projeto_radar_backend.DTOs
{
  public class PedidosProdutoDTO
  {
    public int PedidoId { get; set; }
    public int ProdutoId { get; set; }
    public decimal? Valor { get; set; }
    public int? Quantidade { get; set; }
  }
}
