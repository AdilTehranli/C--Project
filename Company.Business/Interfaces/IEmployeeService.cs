using ConsoleProject.Entities;

namespace Company.Business.Interfaces;

public interface IEmployeeService
{
    void Create(string employeeName,int capacity);
    void Delete(string employeeName);
    void Update(int id,int  capacity);
    Employee GetByName(string employeeName);
    Employee GetById(int id);
    List<Employee> GetAll();
}
