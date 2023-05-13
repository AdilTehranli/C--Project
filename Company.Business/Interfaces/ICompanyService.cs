namespace Company.Business.Interfaces;
using ConsoleProject.Entities;

public interface ICompanyService
{
    void Create(string name);
    void Delete(string name);
    void GetByName(string name);
    void GetById(int id);
   List<Company>GetAll();
}
