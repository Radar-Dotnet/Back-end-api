using Microsoft.EntityFrameworkCore;
using projeto_radar_backend.Models;
using projeto_radar_backend.Repository.Interfaces;

namespace projeto_radar_backend.Repository.Entity
{
  public class UserRepository : IServiceUser<User>
  {
    private EntityContext _context;
    public UserRepository()
    {
      _context = new EntityContext();
    }
    public async Task<User?> Login(string email, string senha)
    {
      return await _context.Users.Where(a => a.Email == email && a.Senha == senha).FirstOrDefaultAsync();
    }

    public async Task<List<User>> GetAllAsync()
    {
      return await _context.Users.ToListAsync();
    }

    public async Task CreateAsync(User user)
    {
      _context.Users.Add(user);
      await _context.SaveChangesAsync();
    }

    public async Task<User> UpdateAsync(User user)
    {
      _context.Entry(user).State = EntityState.Modified;
      await _context.SaveChangesAsync();

      return user;
    }

    public async Task DeleteAsync(User user)
    {
      var obj = await _context.Users.FindAsync(user.Id);
      if (obj is null) throw new Exception("Usuário não encontrado");
      _context.Users.Remove(obj);
      await _context.SaveChangesAsync();
    }
  }
}