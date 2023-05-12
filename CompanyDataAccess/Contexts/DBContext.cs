using ConsoleProject.Entities;

namespace CompanyDataAccess.Contexts;

public static class DBContext
{
    public static List<Employee> employees { get; set; } = new();
    public static List<Department> departments { get; set; } = new();
    public static List<Company> companies { get; set; } = new();
}
