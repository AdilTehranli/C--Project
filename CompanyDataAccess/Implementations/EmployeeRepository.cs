using CompanyDataAccess.Contexts;
using CompanyDataAccess.Interfaces;
using ConsoleProject.Entities;
using System.Xml.Linq;

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
    public void Delete(Employee entity)
    {
        DBContext.employees.Remove(entity);
    }
    public List<Employee> GetAll()
    {
        return DBContext.employees;
    }

    public Employee GetByName(string name)
    {
        return DBContext.employees.Find(cp => cp.Name == name);
    }

    public List<Employee> GetAllByName(string name)
    {
        return DBContext.employees.FindAll(cp => cp.Name == name);
    }
    public List<Employee> GetEmployeeById(int id)
    {
        return DBContext.employees.FindAll(cp => cp.EmployeeId == id);
    }

}
