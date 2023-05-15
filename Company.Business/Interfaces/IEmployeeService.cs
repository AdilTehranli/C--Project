using Company.Business.DTOs.EmplyeeDto;
using ConsoleProject.Entities;

namespace Company.Business.Interfaces;

public interface IEmployeeService
{
    void Create(EmployeeCreateDto employeeCreateDto);
    void Delete(int id);
    void Update(int id, EmployeeCreateDto employeeCreateDto);
    List<Employee> GetAll();
    List<Employee>GetEmployeeByDepartmentName(int id);
    List<Employee> GetEmployeeByName(string name);
    Employee GetEmployeeById(int id);
}


    