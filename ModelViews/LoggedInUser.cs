namespace projeto_radar_backend.ModelViews
{
	public record LoggedInUser
	{
    public int Id { get; set; } = default!;
    public string Nome { get; set; } = default!;
    public string Email { get; set; } = default!;
    public string Nivel { get; set; } = default!;
    public string Token { get; set; } = default!;
  }
}
