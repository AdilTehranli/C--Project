using Company.Business.DTOs.EmplyeeDto;
using Company.Business.Exceptions;
using Company.Business.Helpers;
using Company.Business.Interfaces;
using CompanyDataAccess.Contexts;
using CompanyDataAccess.Implementations;
using ConsoleProject.Entities;

namespace Company.Business.Services;

public class EmployeeService : IEmployeeService
{
    public EmployeeRepository employeerepository { get;}
    public CompanyRepository companyRepository { get; }
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
        var employee = DBContext.employees.Find(ep => ep.EmployeeId == id);
        if (employee == null)
        {
            throw new NotFoundException(Helper.errors["NotFoundException"]);
        }
        else
        {
            DBContext.employees.Remove(employee);
        }
    }
    public void Update(int id, EmployeeCreateDto employeeCreateDto)
    {
        var employee = employeeCreateDto.salary;
        var employee1 = employeeCreateDto.departmentName;
        
    }

    public List<Employee> GetAll()
    {
        return DBContext.employees;
    }

    public List<Employee> GetEmployeeByDepartmentName(int id)
    {
        return DBContext.employees.FindAll(ep => ep.EmployeeId == id);
    }

    public List<Employee> GetEmployeeByName(string name)
    {
       return DBContext.employees.FindAll(ep => ep.Name==name);
    }
        
    public Employee GetEmployeeById(int id)
    {
        return DBContext.employees.Find(ep => ep.EmployeeId == id);
    }


}
