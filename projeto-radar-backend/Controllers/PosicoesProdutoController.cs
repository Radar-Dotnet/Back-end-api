using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using projeto_radar_backend.Database;
using projeto_radar_backend.Models;

namespace projeto_radar_backend.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
    [AllowAnonymous]
    public class PosicoesProdutoController : ControllerBase
  {
    private readonly DbRadarContext _context;

    public PosicoesProdutoController(DbRadarContext context)
    {
      _context = context;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<PosicoesProduto>>> GetPosicoesProdutos()
    {
      if (_context.PosicoesProdutos == null) return NotFound();

      return await _context.PosicoesProdutos.ToListAsync();
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<PosicoesProduto>> GetPosicoesProduto(int id)
    {
      if (_context.PosicoesProdutos == null) return NotFound();

      var posicoesProduto = await _context.PosicoesProdutos.FindAsync(id);

      if (posicoesProduto == null) return NotFound();

      return posicoesProduto;
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> PutPosicoesProduto(int id, PosicoesProduto posicoesProduto)
    {
      if (id != posicoesProduto.Id) return BadRequest();

      _context.Entry(posicoesProduto).State = EntityState.Modified;

      try
      {
        await _context.SaveChangesAsync();
      }
      catch (DbUpdateConcurrencyException)
      {
        if (!PosicoesProdutoExists(id))
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
    public async Task<ActionResult<PosicoesProduto>> PostPosicoesProduto(PosicoesProduto posicoesProduto)
    {
      if (_context.PosicoesProdutos == null)
        return Problem("Entity set 'DbRadarContext.PosicoesProdutos'  is null.");

      _context.PosicoesProdutos.Add(posicoesProduto);
      await _context.SaveChangesAsync();

      return CreatedAtAction("GetPosicoesProduto", new { id = posicoesProduto.Id }, posicoesProduto);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeletePosicoesProduto(int id)
    {
      if (_context.PosicoesProdutos == null) return NotFound();

      var posicoesProduto = await _context.PosicoesProdutos.FindAsync(id);
      if (posicoesProduto == null) return NotFound();

      _context.PosicoesProdutos.Remove(posicoesProduto);
      await _context.SaveChangesAsync();

      return NoContent();
    }

    private bool PosicoesProdutoExists(int id)
    {
      return (_context.PosicoesProdutos?.Any(e => e.Id == id)).GetValueOrDefault();
    }
  }
}
