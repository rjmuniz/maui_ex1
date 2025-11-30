using System.Collections.ObjectModel;

namespace Common.Library.Interfaces;

public interface IRepository<TEntity>
{
    Task<ObservableCollection<TEntity>> GetAsync();
    Task<TEntity?> GetAsync(int id);
}