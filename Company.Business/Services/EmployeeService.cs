using Company.Business.DTOs.EmplyeeDto;
using Company.Business.Exceptions;
using Company.Business.Helpers;
using Company.Business.Interfaces;
using CompanyDataAccess.Implementations;
using ConsoleProject.Entities;
using System.Xml.Linq;

namespace Company.Business.Services;

public class EmployeeService : IEmployeeService
{
    public EmployeeRepository employeerepository { get;}
    public CompanyRepository companyRepository { get;}
    public DepartmentRepository departmentRepository { get;}
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
            throw new NotValidWordException(Helper.errors["NotValidWordException"]);
        }
        var surname=employeeCreateDto.surname.Trim();   
        if(!string.IsNullOrWhiteSpace(surname))
        {
            if (!surname.IsOnlyLetters())
            {
                throw new NotValidWordException(Helper.errors["NotValidWordException"]);
            }
        }
        var department = departmentRepository.GetByName(employeeCreateDto.departmentName.Trim());
        if (department == null)
        {
            throw new NotFoundException($"{employeeCreateDto.departmentName}-doesn't exist");
        }
        var count = employeerepository.GetEmployeeById(department.DepartmentId).Count;
        if (count >= department.EmployeeLimit)
        {
            throw new DepartmentNotEnoughException(Helper.errors["DepartmentNotEnoughException"]);
        }
        Employee employee = new Employee(name,surname,department.DepartmentId);
        employeerepository.Add(employee);
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
