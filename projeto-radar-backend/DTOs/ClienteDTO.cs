﻿namespace projeto_radar_backend.DTOs
{
  public record ClienteDTO
  {
    public string Nome { get; set; } = default!;
    public string Telefone { get; set; } = default!;
    public string Email { get; set; } = default!;
    public string Cpf { get; set; } = default!;
    public string Cep { get; set; } = default!;
    public string Logradouro { get; set; } = default!;
    public int? Numero { get; set; }
    public string Bairro { get; set; } = default!;
    public string Cidade { get; set; } = default!;
    public string Estado { get; set; } = default!;
    public string? Complemento { get; set; }
  }
}

