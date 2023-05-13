using CompanyDataAccess.Contexts;
using CompanyDataAccess.Interfaces;
using ConsoleProject.Entities;

namespace CompanyDataAccess.Implementations;

public class EmployeeRepository : IRepository<Employee>
{
    public void Update(Employee entity)
    {
       Employee employee=  DBContext.employees.Find(em => em.EmployeeId == entity.EmployeeId);
        employee.Name = entity.Name;
        employee.Surname = entity.Surname;
        employee.Salary = entity.Salary;

    }
    public Employee Get(int id)
    {
        return DBContext.employees.Find(em => em.EmployeeId == id);
    }
    public void Add(Employee entity)
    {
        DBContext.employees.Add(entity);
    }

    public List<Employee> GetAll()
    {
        return DBContext.employees;
    }

}
