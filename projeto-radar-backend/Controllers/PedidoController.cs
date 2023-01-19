using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
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
    public class PedidoController : ControllerBase
    {
        private readonly DbRadarContext _context;

        public PedidoController(DbRadarContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Pedido>>> GetPedidos()
        {
          if (_context.Pedidos == null)
          {
              return NotFound();
          }
            return await _context.Pedidos.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Pedido>> GetPedido(int id)
        {
          if (_context.Pedidos == null)
          {
              return NotFound();
          }
            var pedido = await _context.Pedidos.FindAsync(id);

            if (pedido == null)
            {
                return NotFound();
            }

            return pedido;
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutPedido(int id, PedidoDTO pedidoDTO)
        {
            if (id != pedidoDTO.Id)
            {
                return BadRequest();
            }

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
        public async Task<ActionResult<Pedido>> PostPedido(Pedido pedido)
        {
          if (_context.Pedidos == null)
          {
              return Problem("Entity set 'DbRadarContext.Pedidos'  is null.");
          }

            //var selectClientePorId = await Task.FromResult(
            //        (
            //        from d in _context.Clientes
            //        where d.Id == pedido.Id
            //        select d
            //        )
            //    );
            //var list = selectClientePorId.Select(s => new {
            //    s.Id,
            //    s.Bairro,
            //    s.Cep,
            //    s.Cidade,
            //    s.Complemento,
            //    s.Cpf,
            //    s.Email,
            //    s.Estado,
            //    s.Logradouro,
            //    s.Nome,
            //    s.Numero,
            //    s.Pedidos,
            //    s.Telefone
            //}).ToList();
            //Console.WriteLine(selectClientePorId);

            var objeto = _context.Clientes.FirstOrDefault(x => x.Id == pedido.Id);
            Console.WriteLine(objeto);
            //if(objeto != null) { pedido.Cliente = objeto; };

            _context.Pedidos.Add(pedido);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPedido", new { id = pedido.Id }, pedido);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePedido(int id)
        {
            if (_context.Pedidos == null)
            {
                return NotFound();
            }
            var pedido = await _context.Pedidos.FindAsync(id);
            if (pedido == null)
            {
                return NotFound();
            }

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
