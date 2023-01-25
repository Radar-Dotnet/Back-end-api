using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using projeto_radar_backend.Database;
using projeto_radar_backend.Models;

namespace projeto_radar_backend.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
    public class UsuarioController : ControllerBase
  {
    private readonly DbRadarContext _context;

    public UsuarioController(DbRadarContext context)
    {
      _context = context;
    }

    [HttpGet]
    [Authorize(Roles = "admin,editor")]
    public async Task<ActionResult<IEnumerable<User>>> GetUsuarios()
    {
      if (_context.Users == null) return NotFound();

      return await _context.Users.ToListAsync();
    }

    [HttpGet("{id}")]
    [Authorize(Roles = "admin,editor")]
    public async Task<ActionResult<User>> GetUsuario(int id)
    {
      if (_context.Users == null) return NotFound();
      var usuario = await _context.Users.FindAsync(id);

      if (usuario == null) return NotFound();

      return usuario;
    }

    [HttpPut("{id}")]
    [Authorize(Roles = "admin")]
    public async Task<IActionResult> PutUsuario(int id, User usuario)
    {
      if (id != usuario.Id) return BadRequest();

      _context.Entry(usuario).State = EntityState.Modified;

      try
      {
        await _context.SaveChangesAsync();
      }
      catch (DbUpdateConcurrencyException)
      {
        if (!UsuarioExists(id))
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
    public async Task<ActionResult<User>> PostUsuario([FromBody] User usuario)
    {

      if (_context.Users == null) return Problem("Entity set 'DbRadarContext.Usuarios'  is null.");

      _context.Users.Add(usuario);
      await _context.SaveChangesAsync();

      return CreatedAtAction("GetUsuario", new { id = usuario.Id }, usuario);
    }

    [HttpDelete("{id}")]
    [Authorize(Roles = "admin")]
    public async Task<IActionResult> DeleteUsuario(int id)
    {
      if (_context.Users == null) return NotFound();

      var usuario = await _context.Users.FindAsync(id);

      if (usuario == null) return NotFound();

      _context.Users.Remove(usuario);
      await _context.SaveChangesAsync();

      return NoContent();
    }

    private bool UsuarioExists(int id)
    {
      return (_context.Users?.Any(e => e.Id == id)).GetValueOrDefault();
    }
  }
}
