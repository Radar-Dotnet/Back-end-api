//using Microsoft.EntityFrameworkCore;
//using projeto_radar_backend.Models;
//using projeto_radar_backend.Repository.Interfaces;

//namespace projeto_radar_backend.Repository.Entity
//{
//  public class ClienteRepository : IService<Cliente>
//  {
//    private Context context;
//    public ClienteRepository()
//    {
//      context = new Context();
//    }

//    public async Task<List<Cliente>> GetAllAsync()
//    {
//      return await context.Clientes.ToListAsync();
//    }

//    public async Task CreateAsync(Cliente cliente)
//    {
//      context.Clientes.Add(cliente);
//      await context.SaveChangesAsync();
//    }

//    public async Task<Cliente> UpdateAsync(Cliente cliente)
//    {
//      context.Entry(cliente).State = EntityState.Modified;
//      await context.SaveChangesAsync();

//      return cliente;
//    }

//    public async Task DeleteAsync(Cliente cliente)
//    {
//      var obj = await context.Clientes.FindAsync(cliente.Id);
//      if (obj is null) throw new Exception("Cliente não encontrado");
//      context.Clientes.Remove(obj);
//      await context.SaveChangesAsync();
//    }
//  }
//}
