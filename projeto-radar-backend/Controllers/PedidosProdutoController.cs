using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using projeto_radar_backend.Database;
using projeto_radar_backend.DTOs;
using projeto_radar_backend.Models;
using projeto_radar_backend.Services;

namespace projeto_radar_backend.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class PedidosProdutoController : ControllerBase
  {
    private readonly DbRadarContext _context;

    public PedidosProdutoController(DbRadarContext context)
    {
      _context = context;
    }

    // GET: api/PedidosProduto
    [HttpGet]
    [Authorize(Roles = "admin, editor")]
    public async Task<ActionResult<IEnumerable<PedidosProduto>>> GetPedidosProdutos()
    {
      if (_context.PedidosProdutos == null) return NotFound();

      return await _context.PedidosProdutos.ToListAsync();
    }

    // GET: api/PedidosProduto/5
    [HttpGet("{id}")]
    [Authorize(Roles = "admin,editor")]
    public async Task<ActionResult<PedidosProduto>> GetPedidosProduto(int id)
    {
      if (_context.PedidosProdutos == null) return NotFound();

      var pedidosProduto = await _context.PedidosProdutos.FindAsync(id);

      if (pedidosProduto == null) return NotFound();

      return pedidosProduto;
    }

    // PUT: api/PedidosProduto/5
    // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
    [HttpPut("{id}")]
    [Authorize(Roles = "admin")]
    public async Task<IActionResult> PutPedidosProduto(int id, PedidosProduto pedidosProduto)
    {
      if (id != pedidosProduto.Id) return BadRequest();

      _context.Entry(pedidosProduto).State = EntityState.Modified;

      try
      {
        await _context.SaveChangesAsync();
      }
      catch (DbUpdateConcurrencyException)
      {
        if (!PedidosProdutoExists(id))
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

    // POST: api/PedidosProduto
    // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
    [HttpPost]
    [Authorize(Roles = "admin")]
    public async Task<ActionResult<PedidosProdutoDTO>> PostPedidosProduto(PedidosProdutoDTO pedidosProduto)
    {
      if (_context.PedidosProdutos == null)
        return Problem("Entity set 'DbRadarContext.PedidosProdutos'  is null.");

      var pedido = DTOBuilder<PedidosProduto>.Builder(pedidosProduto);
      _context.PedidosProdutos.Add(pedido);
      await _context.SaveChangesAsync();

      return CreatedAtAction("GetPedidosProduto", new { id = pedido.Id }, pedido);
    }

    // DELETE: api/PedidosProduto/5
    [HttpDelete("{id}")]
    [Authorize(Roles = "admin")]
    public async Task<IActionResult> DeletePedidosProduto(int id)
    {
      if (_context.PedidosProdutos == null) return NotFound();

      var pedidosProduto = await _context.PedidosProdutos.FindAsync(id);
      if (pedidosProduto == null) return NotFound();

      _context.PedidosProdutos.Remove(pedidosProduto);
      await _context.SaveChangesAsync();

      return NoContent();
    }

    private bool PedidosProdutoExists(int id)
    {
      return (_context.PedidosProdutos?.Any(e => e.Id == id)).GetValueOrDefault();
    }
  }
}
