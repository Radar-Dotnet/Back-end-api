namespace projeto_radar_backend.DTOs
{
  public class CampanhaDTO
  {
    public int ClienteId { get; set; } = default!;
    public decimal? ValorTotal { get; set; }
    public DateTime Data { get; set; }
  }
}