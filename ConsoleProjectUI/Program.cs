using Company.Business.Services;
using CompanyDataAccess.Contexts;

//EmployeeRepository employeeRepository = new EmployeeRepository();
EmployeeService employeeService = new EmployeeService();
DepartmentService departmentService = new DepartmentService();
CompanyService companyService = new CompanyService();
companyService.Create("adil");
employeeService.GetAll();
foreach (var com in departmentService)
{
    Console.WriteLine();
}





//companyService.Create();

//departmentService.Create("mm","Adil",10);
//departmentService.Create("mmc", "desing1", 19);
//EmployeeCreateDto employeeCreateDto = new("adil", "tehranli", 1000, "mmx");
//employeeService.Create(employeeCreateDto);
//Console.WriteLine("a");
//departmentService.GetById(0);
