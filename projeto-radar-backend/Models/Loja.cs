using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace projeto_radar_backend.Models
{
    public record Loja
    {
        public int Id { get; set; }= default!;
        public string Nome { get; set; } = default!;
        public string? Observacao { get; set; }
        public string Cep { get; set; } = default!;
        public string Logradouro { get; set; } = default!;
        public int Numero { get; set; }
        public string Bairro { get; set; } = default!;
        public string Cidade { get; set; } = default!;
        public string Estado { get; set; } = default!;
        public string? Complemento { get; set; }
        public string Latitude { get; set; } = default!;
        public string Longitude { get; set; } = default!;
    }
}
