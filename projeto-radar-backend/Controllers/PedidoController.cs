using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using projeto_radar_backend.Database;
using projeto_radar_backend.DTOs;
using projeto_radar_backend.Models;

namespace projeto_radar_backend.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
    [AllowAnonymous]
    public class PedidoController : ControllerBase
  {
    private readonly DbRadarContext _context;

    public PedidoController(DbRadarContext context)
    {
      _context = context;
    }

    [HttpGet]
    [Authorize(Roles = "admin,editor")]
    public async Task<ActionResult<IEnumerable<Pedido>>> GetPedidos()
    {
      if (_context.Pedidos == null) return NotFound();


            var pedidoComClienteNome = await Task.FromResult(
                from c in _context.Clientes
                from p in _context.Pedidos
                where c.Id == p.ClienteId
                orderby p.Id
                select new PedidoDTO
                {
                    Id = p.Id,
                    ClienteId = p.Id,
                    NomeCliente = c.Email,
                    Data = p.Data,
                    ValorTotal = p.ValorTotal
                });
            return Ok(pedidoComClienteNome);
        }

    [HttpGet("{id}")]
    [Authorize(Roles = "admin,editor")]
    public async Task<ActionResult<Pedido>> GetPedido(int id)
    {
      if (_context.Pedidos == null) return NotFound();

      var pedido = await _context.Pedidos.FindAsync(id);


      if (pedido == null) return NotFound();

      return pedido;
    }

    [HttpPut("{id}")]
    [Authorize(Roles = "admin")]
    public async Task<IActionResult> PutPedido(int id, PedidoDTO pedidoDTO)
    {
      if (id != pedidoDTO.Id) return BadRequest();

      _context.Entry(pedidoDTO).State = EntityState.Modified;

      try
      {
        await _context.SaveChangesAsync();
      }
      catch (DbUpdateConcurrencyException)
      {
        if (!PedidoExists(id))
        {
          return NotFound();
        }
        else
        {
          throw;
        }
      }

      return NoContent();
        }

    [HttpPost]
    [Authorize(Roles = "admin")]
    public async Task<ActionResult<Pedido>> PostPedido(Pedido pedido)
    {
      if (_context.Pedidos == null)
        return Problem("Entity set 'DbRadarContext.Pedidos'  is null.");

      var objeto = _context.Clientes.FirstOrDefault(x => x.Id == pedido.Id);

      _context.Pedidos.Add(pedido);
      await _context.SaveChangesAsync();

      return CreatedAtAction("GetPedido", new { id = pedido.Id }, pedido);
    }

    [HttpDelete("{id}")]
    [Authorize(Roles = "admin")]
    public async Task<IActionResult> DeletePedido(int id)
    {
      if (_context.Pedidos == null) return NotFound();

      var pedido = await _context.Pedidos.FindAsync(id);

      if (pedido == null) return NotFound();

      _context.Pedidos.Remove(pedido);
      await _context.SaveChangesAsync();

      return NoContent();
    }

    private bool PedidoExists(int id)
    {
      return (_context.Pedidos?.Any(e => e.Id == id)).GetValueOrDefault();
    }
  }
}
