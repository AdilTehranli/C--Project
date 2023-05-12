using ConsoleProject.Interfaces;

namespace CompanyDataAccess.Interfaces;

public interface IRepository<T> where T : IEntity
{
    void Add(T entity);
    void Update(T entity);
    T Get(int id);
    List<T> GetAll();
}
