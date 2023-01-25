using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using projeto_radar_backend.Database;
using projeto_radar_backend.Models;

namespace projeto_radar_backend.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
    public class LojaController : ControllerBase
  {
    private readonly DbRadarContext _context;

    public LojaController(DbRadarContext context)
    {
      _context = context;
    }

    [HttpGet]
    [Authorize(Roles = "admin,editor")]
    public async Task<ActionResult<IEnumerable<Loja>>> GetLojas()
    {
      if (_context.Lojas == null) return NotFound();

      return await _context.Lojas.ToListAsync();
    }

    [HttpGet("{id}")]
    [Authorize(Roles = "admin,editor")]
    public async Task<ActionResult<Loja>> GetLoja(int id)
    {
      if (_context.Lojas == null) return NotFound();

      var loja = await _context.Lojas.FindAsync(id);

      if (loja == null) return NotFound();

      return loja;
    }

    [HttpPut("{id}")]
    [Authorize(Roles = "admin")]
    public async Task<IActionResult> PutLoja(int id, Loja loja)
    {
      if (id != loja.Id) return BadRequest();

      _context.Entry(loja).State = EntityState.Modified;

      try
      {
        await _context.SaveChangesAsync();
      }
      catch (DbUpdateConcurrencyException)
      {
        if (!LojaExists(id))
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
    public async Task<ActionResult<Loja>> PostLoja(Loja loja)
    {
      if (_context.Lojas == null)
        return Problem("Entity set 'DbRadarContext.Lojas'  is null.");

      _context.Lojas.Add(loja);
      await _context.SaveChangesAsync();

      return CreatedAtAction("GetLoja", new { id = loja.Id }, loja);
    }

    [HttpDelete("{id}")]
    [Authorize(Roles = "admin")]
    public async Task<IActionResult> DeleteLoja(int id)
    {
      if (_context.Lojas == null) return NotFound();

      var loja = await _context.Lojas.FindAsync(id);

      if (loja == null) return NotFound();

      _context.Lojas.Remove(loja);
      await _context.SaveChangesAsync();

      return NoContent();
    }

    private bool LojaExists(int id)
    {
      return (_context.Lojas?.Any(e => e.Id == id)).GetValueOrDefault();
    }
  }
}
