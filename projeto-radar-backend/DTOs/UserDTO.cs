namespace projeto_radar_backend.DTOs
{
  public record UserDTO
  {
    public string Email { get; set; } = default!;
    public string Senha { get; set; } = default!;
  }
}
