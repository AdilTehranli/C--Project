using Company.Business.Exceptions;
using Company.Business.Helpers;
using Company.Business.Interfaces;
using CompanyDataAccess.Contexts;
using CompanyDataAccess.Implementations;
using ConsoleProject.Entities;

namespace Company.Business.Services;

public class DepartmentService:IDepartmentService
{
    public EmployeeRepository employeeRepository { get; }
    public DepartmentRepository departmentRepository { get; }
    public CompanyRepository companyRepository { get; }
    public DepartmentService()
    {
        departmentRepository = new DepartmentRepository();
        companyRepository = new CompanyRepository();
    }
    public void Create(string departmentName, string Name, int employeeLimit)
    {
        var name = departmentName.Trim();
        if (string.IsNullOrWhiteSpace(name))
        {
            throw new NullReferenceException();
        }
        if (departmentRepository.GetByName(name) != null)
        {
            throw new AlreadyExistException(Helper.errors["AlreadyExistException"]);
        }
        var companyName = companyRepository.GetByName(Name);
        if (companyName == null)
        {
            throw new NotFoundException($"{Name} - doesn't exist");
        }
        if (employeeLimit <= 2)
        {
            throw new SizeException(Helper.errors["SizeException"]);
        }   
        Department department = new Department(departmentName, employeeLimit, companyName.CompanyId);
        departmentRepository.Add(department);
    }

    public void Delete(string departmentName)
    {
        var department = DBContext.departments.Find(dep => dep.Name == departmentName);
        if (department != null)
        {
            DBContext.departments.Remove(department);
        }
        else
        {
            throw new NotFoundException("This is department doesn't exist");
        }
        var count = DBContext.departments.Count(emp => emp.Name == departmentName);
        if (count != 0)
        {
            throw new IsNotEmptyException("This is department isn't empty");
        }
    }
    public List<Department> GetAll()
    {
        return DBContext.departments;
    }
    public Department GetById(int id)
    {
        var count = DBContext.departments.Count();
        if (count<id) 
        { 
            throw new NotFoundException("This id was not found");
        }
        else
        {
        return DBContext.departments.Find(dep => dep.DepartmentId == id);

        }
    }
    public Department GetByName(string departmentName)
    {
        var department=DBContext.departments.Find(de=>de.Name == departmentName);
        if(department != null)
        {
            throw new NotFoundException ("no such name");
        }
        else
        {

          return DBContext.departments.Find(dep => dep.Name == departmentName);
        }
    }
    public void Update(int id, int employeeLimit)
    {
        var count=DBContext.departments.Count();
        if(count<employeeLimit)
        {
            throw new NotFoundException("You cannat exceed the capacity");

        }
        else
        {
            DBContext.departments.Find(dpe => dpe.DepartmentId == id && dpe.EmployeeLimit == employeeLimit);
        }
    }
}
