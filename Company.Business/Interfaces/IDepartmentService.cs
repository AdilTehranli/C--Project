using ConsoleProject.Entities;

namespace Company.Business.Interfaces;

public interface IDepartmentService
{
    void AddEmployee(string v,string v1,Employee employee);
    void Create(string departmentName, string name, int employeeLimit);
    void Delete(string departmentName);
    void Update(int id, int employeeLimit);
    Department GetByName(string departmentName);
    Department GetById(int id);
    List<Department> GetAll();
}
