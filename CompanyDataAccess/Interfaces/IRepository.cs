using ConsoleProject.Interfaces;

namespace CompanyDataAccess.Interfaces;

public interface IRepository<T> where T : IEntity
{
    void Update(T entity);
    T Get(int id);
    void Add(T entity);
    List<T> GetAll();
    T GetByName(string name);
    List<T> GetAllByName(string name);

}

