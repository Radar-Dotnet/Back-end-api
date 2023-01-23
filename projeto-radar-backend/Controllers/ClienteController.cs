using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using projeto_radar_backend.DTOs;
using projeto_radar_backend.Models;
using projeto_radar_backend.Repository.Interfaces;
using projeto_radar_backend.Services;

namespace projeto_radar_backend.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class ClienteController : ControllerBase
  {
    private readonly IService<Cliente> _service;
    public ClienteController(IService<Cliente> service)
    {
      _service = service;
    }

    [HttpGet("")]
    [Authorize(Roles = "admin,editor")]
    public async Task<IActionResult> GetAll()
    {
      var clientes = await _service.GetAllAsync();
      if (clientes is null)
        return StatusCode(404, new { Message = "Nenhum cliente foi encontrado."});

      return StatusCode(200, clientes);
    }

    [HttpGet("{id}")]
    [Authorize(Roles = "admin,editor")]
    public async Task<IActionResult> Get([FromRoute] int id)
    {
      var cliente = (await _service.GetAllAsync()).Find(c => c.Id == id);
      if (id != cliente?.Id)
        return StatusCode(400, new { Message = "Id inválido" });
      if (cliente is null)
        return StatusCode(404, new { Message = "O cliente enviado não foi encontrado" });
      
      return StatusCode(200, cliente);
    }

    [HttpPut("{id}")]
    [Authorize(Roles = "admin")]
    public async Task<IActionResult> Update([FromRoute]int id,[FromBody] Cliente cliente)
    {
      if (id != cliente.Id)
        return StatusCode(400, new { Message = "O Id do cliente deve ser o mesmo id da URL" });

      var clienteDb = await _service.UpdateAsync(cliente);
      return StatusCode(200, clienteDb);
     
    }

    [HttpPost]
    [Authorize(Roles = "admin")]
    public async Task<IActionResult> Create([FromBody] ClienteDTO clienteDto)
    {
      var cliente = DTOBuilder<Cliente>.Builder(clienteDto);
      await _service.CreateAsync(cliente);
      return StatusCode(201, cliente);
    }

    [HttpDelete("{id}")]
    [Authorize(Roles = "admin")]
    public async Task<IActionResult> Delete(int id)
    {

      var cliente = (await _service.GetAllAsync()).Find(c => c.Id == id);

      if (cliente is null)
        return StatusCode(404, new { Message = "O cliente não existe." });

      await _service .DeleteAsync(cliente);

      return StatusCode(204);
    }
  }
}
