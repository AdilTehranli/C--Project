using Company.Business.DTOs.EmplyeeDto;
using Company.Business.Exceptions;
using Company.Business.Helpers;
using Company.Business.Interfaces;
using CompanyDataAccess.Implementations;
using ConsoleProject.Entities;

namespace Company.Business.Services;

public class EmployeeService : IEmployeeService
{
    public EmployeeRepository employeerepository { get;}
    public CompanyRepository companyRepository { get;}
    public EmployeeService()
    {
        employeerepository = new();
        companyRepository = new();
    }
    public void Create(string employeeName, string name, int capacity)
    {
        var name=employeeCreateDto.name.Trim();
        if (string.IsNullOrEmpty(name))
        {
            throw new SizeException(Helper.errors["SizeException"]);
        }
        if(employeerepository.GetByName(name) == null)
        {
            throw new AlreadyExistException(Helper.errors["AlreadyExistException"]);
        }
    }

    public void Create(EmployeeCreateDto employeeCreateDto)
    {
        throw new NotImplementedException();
    }

    public void Delete(int id)
    {
        throw new NotImplementedException();
    }

    public void Update(int id, EmployeeCreateDto employeeCreateDto)
    {
        throw new NotImplementedException();
    }

    public List<Employee> GetAll(int skip, int take)
    {
        throw new NotImplementedException();
    }

    public List<Employee> GetEmployeeByDepartmentName(int id)
    {
        throw new NotImplementedException();
    }

    public List<Employee> GetEmplyeeByName(string name)
    {
        throw new NotImplementedException();
    }

    public Employee GetEmployeeById(int id)
    {
        throw new NotImplementedException();
    }
}
