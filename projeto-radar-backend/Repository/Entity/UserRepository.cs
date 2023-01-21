//using Microsoft.EntityFrameworkCore;
//using projeto_radar_backend.Models;
//using projeto_radar_backend.Repository.Interfaces;

//namespace projeto_radar_backend.Repository.Entity
//{
//  public class UserRepository : IServiceUser<User>
//  {
//    private Context context;
//    public UserRepository()
//    {
//      context = new Context();
//    }
//    public async Task<User?> Login(string email, string senha)
//    {
//      return await context.Users.Where(a => a.Email == email && a.Senha == senha).FirstOrDefaultAsync();
//    }

//    public async Task<List<User>> GetAllAsync()
//    {
//      return await context.Users.ToListAsync();
//    }

//    public async Task CreateAsync(User user)
//    {
//      context.Users.Add(user);
//      await context.SaveChangesAsync();
//    }

//    public async Task<User> UpdateAsync(User user)
//    {
//      context.Entry(user).State = EntityState.Modified;
//      await context.SaveChangesAsync();

//      return user;
//    }

//    public async Task DeleteAsync(User user)
//    {
//      var obj = await context.Users.FindAsync(user.Id);
//      if (obj is null) throw new Exception("User não encontrado");
//      context.Users.Remove(obj);
//      await context.SaveChangesAsync();
//    }
//  }
//}