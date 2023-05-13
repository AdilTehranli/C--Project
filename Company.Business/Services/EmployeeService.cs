using Company.Business.Exceptions;
using Company.Business.Helpers;
using Company.Business.Interfaces;
using CompanyDataAccess.Implementations;
using ConsoleProject.Entities;

namespace Company.Business.Services;

public class EmployeeService : IEmployeeService
{
    public EmployeeRepository employeerepository { get;}
    public EmployeeService()
    {
        employeerepository = new EmployeeRepository();
    }
    public void Create(string employeeName, string name, int capacity)
    {
        var name1=employeeName.Trim();
        if (string.IsNullOrEmpty(name1))
        {
            throw new SizeException(Helper.errors["SizeException"]);
        }
        if(employeerepository.GetByName(name1) == null)
        {
            throw new AlreadyExistException(Helper.errors["AlreadyExistException"]);
        }
    }

    public void Delete(string employeeName)
    {
        throw new NotImplementedException();
    }

    public List<Employee> GetAll()
    {
        throw new NotImplementedException();
    }

    public Employee GetById(int id)
    {
        throw new NotImplementedException();
    }

    public Employee GetByName(string employeeName)
    {
        throw new NotImplementedException();
    }

    public void Update(int id, int capacity)
    {
        throw new NotImplementedException();
    }
}
