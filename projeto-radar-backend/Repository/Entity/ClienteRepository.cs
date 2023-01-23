using Microsoft.EntityFrameworkCore;
using projeto_radar_backend.Models;
using projeto_radar_backend.Repository.Interfaces;

namespace projeto_radar_backend.Repository.Entity
{
  public class ClienteRepository : IService<Cliente>
  {
    private EntityContext _context;
    public ClienteRepository()
    {
      _context = new EntityContext();
    }

    public async Task<List<Cliente>> GetAllAsync()
    {
      return await _context.Clientes.ToListAsync();
    }

    public async Task CreateAsync(Cliente cliente)
    {
      _context.Clientes.Add(cliente);
      await _context.SaveChangesAsync();
    }

    public async Task<Cliente> UpdateAsync(Cliente cliente)
    {
      _context.Entry(cliente).State = EntityState.Modified;
      await _context.SaveChangesAsync();

      return cliente;
    }

    public async Task DeleteAsync(Cliente cliente)
    {
      var obj = await _context.Clientes.FindAsync(cliente.Id);
      if (obj is null) throw new Exception("Cliente não encontrado");
      _context.Clientes.Remove(obj);
      await _context.SaveChangesAsync();
    }
  }
}
