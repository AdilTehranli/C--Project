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
    public void Create( EmployeeCreateDto employeeCreateDto)
    {
        var name= employeeCreateDto.name.Trim();
        if (string.IsNullOrWhiteSpace(name))
        {
            throw new NullReferenceException();
        }
        if(!name.IsOnlyLetters())
        {
            throw new AlreadyExistException(Helper.errors["AlreadyExistException"]);
        }
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
