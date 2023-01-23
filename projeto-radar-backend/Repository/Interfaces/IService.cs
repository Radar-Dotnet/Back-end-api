namespace projeto_radar_backend.Repository.Interfaces
{
  public interface IService<T>
  {
    Task<List<T>> GetAllAsync();
    Task CreateAsync(T obj);
    Task<T> UpdateAsync(T obj);
    Task DeleteAsync(T obj);
  }
}
