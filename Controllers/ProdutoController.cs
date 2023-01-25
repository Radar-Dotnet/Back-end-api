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
    public class ProdutoController : ControllerBase
  {
    private readonly DbRadarContext _context;

    public ProdutoController(DbRadarContext context)
    {
      _context = context;
    }

    [HttpGet]
        [Authorize(Roles = "admin,editor")]
        public async Task<ActionResult<IEnumerable<Produto>>> GetProdutos()
    {
      if (_context.Produtos == null) return NotFound();

      return await _context.Produtos.ToListAsync();
    }

    [HttpGet("{id}")]
        [Authorize(Roles = "admin")]
        public async Task<ActionResult<Produto>> GetProduto(int id)
    {
      if (_context.Produtos == null) return NotFound();

      var produto = await _context.Produtos.FindAsync(id);

      if (produto == null) return NotFound();

      return produto;
    }

    [HttpPut("{id}")]
        [Authorize(Roles = "admin")]
        public async Task<IActionResult> PutProduto(int id, Produto produto)
    {
      if (id != produto.Id) return BadRequest();

      _context.Entry(produto).State = EntityState.Modified;

      try
      {
        await _context.SaveChangesAsync();
      }
      catch (DbUpdateConcurrencyException)
      {
        if (!ProdutoExists(id))
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
        public async Task<ActionResult<Produto>> PostProduto(ProdutoDTO produtoDTO)
    {
      var produto = DTOBuilder<Produto>.Builder(produtoDTO);
      if (_context.Produtos == null)
        return Problem("Entity set 'DbRadarContext.Produtos'  is null.");

      _context.Produtos.Add(produto);
      await _context.SaveChangesAsync();

      return CreatedAtAction("GetProduto", new { id = produto.Id }, produto);
    }

    [HttpDelete("{id}")]
        [Authorize(Roles = "admin")]
        public async Task<IActionResult> DeleteProduto(int id)
    {
      if (_context.Produtos == null) return NotFound();

      var produto = await _context.Produtos.FindAsync(id);
      if (produto == null) return NotFound();

      _context.Produtos.Remove(produto);
      await _context.SaveChangesAsync();

      return NoContent();
    }

    private bool ProdutoExists(int id)
    {
      return (_context.Produtos?.Any(e => e.Id == id)).GetValueOrDefault();
    }
  }
}
