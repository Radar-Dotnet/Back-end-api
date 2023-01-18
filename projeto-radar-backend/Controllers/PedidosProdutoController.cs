using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using projeto_radar_backend.Database;
using projeto_radar_backend.Models;

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
        public async Task<ActionResult<IEnumerable<PedidosProduto>>> GetPedidosProdutos()
        {
          if (_context.PedidosProdutos == null)
          {
              return NotFound();
          }
            return await _context.PedidosProdutos.ToListAsync();
        }

        // GET: api/PedidosProduto/5
        [HttpGet("{id}")]
        public async Task<ActionResult<PedidosProduto>> GetPedidosProduto(int id)
        {
          if (_context.PedidosProdutos == null)
          {
              return NotFound();
          }
            var pedidosProduto = await _context.PedidosProdutos.FindAsync(id);

            if (pedidosProduto == null)
            {
                return NotFound();
            }

            return pedidosProduto;
        }

        // PUT: api/PedidosProduto/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPedidosProduto(int id, PedidosProduto pedidosProduto)
        {
            if (id != pedidosProduto.Id)
            {
                return BadRequest();
            }

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
        public async Task<ActionResult<PedidosProduto>> PostPedidosProduto(PedidosProduto pedidosProduto)
        {
          if (_context.PedidosProdutos == null)
          {
              return Problem("Entity set 'DbRadarContext.PedidosProdutos'  is null.");
          }
            _context.PedidosProdutos.Add(pedidosProduto);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPedidosProduto", new { id = pedidosProduto.Id }, pedidosProduto);
        }

        // DELETE: api/PedidosProduto/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePedidosProduto(int id)
        {
            if (_context.PedidosProdutos == null)
            {
                return NotFound();
            }
            var pedidosProduto = await _context.PedidosProdutos.FindAsync(id);
            if (pedidosProduto == null)
            {
                return NotFound();
            }

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
