using Company.Business.DTOs.EmplyeeDto;
using Company.Business.Interfaces;
using Company.Business.Services;
using CompanyDataAccess.Implementations;

EmployeeRepository employeeRepository = new EmployeeRepository();
EmployeeService employeeService = new EmployeeService();
DepartmentService departmentService = new DepartmentService();
CompanyService companyService = new CompanyService();
companyService.Create("adil");

departmentService.Create("register", "adil", 16);
EmployeeCreateDto employeeCreateDto = new("adil", "tehranli", 1000, "mmx");
employeeService.Create(employeeCreateDto);
Console.WriteLine("a");
departmentService.GetById(0);
