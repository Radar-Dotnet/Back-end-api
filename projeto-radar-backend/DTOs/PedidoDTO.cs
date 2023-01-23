namespace projeto_radar_backend.DTOs
{
	public record PedidoDTO
	{
        public int Id { get; set; }
        public int ClienteId { get; set; }
        public int ValorTotal { get; set; }
        public DateTime Data { get; set; }
    }
}

