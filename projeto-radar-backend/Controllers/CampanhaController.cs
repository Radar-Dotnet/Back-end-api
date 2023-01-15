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
    public class CampanhaController : ControllerBase
    {
        private readonly DbRadarContext _context;

        public CampanhaController(DbRadarContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Campanha>>> GetCampanhas()
        {
          if (_context.Campanhas == null)
          {
              return NotFound();
          }
            return await _context.Campanhas.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Campanha>> GetCampanha(int id)
        {
          if (_context.Campanhas == null)
          {
              return NotFound();
          }
            var campanha = await _context.Campanhas.FindAsync(id);

            if (campanha == null)
            {
                return NotFound();
            }

            return campanha;
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutCampanha(int id, Campanha campanha)
        {
            if (id != campanha.Id)
            {
                return BadRequest();
            }

            _context.Entry(campanha).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CampanhaExists(id))
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
        public async Task<ActionResult<Campanha>> PostCampanha(Campanha campanha)
        {
          if (_context.Campanhas == null)
          {
              return Problem("Entity set 'DbRadarContext.Campanhas'  is null.");
          }
            _context.Campanhas.Add(campanha);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCampanha", new { id = campanha.Id }, campanha);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCampanha(int id)
        {
            if (_context.Campanhas == null)
            {
                return NotFound();
            }
            var campanha = await _context.Campanhas.FindAsync(id);
            if (campanha == null)
            {
                return NotFound();
            }

            _context.Campanhas.Remove(campanha);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool CampanhaExists(int id)
        {
            return (_context.Campanhas?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
