using ConsoleProject.Interfaces;

namespace ConsoleProject.Entities;

public class Employee:IEntity
{
    private static int _id;
    public int EmployeeId { get; }
    public double Salary { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
    public static int DepartmentId { get; set; }
    public Employee()
    {
        EmployeeId = _id;
        _id++;
    }
    public Employee(string name,string surname,double salary)
    {
        Name = name;
        Surname = surname;
        Salary = salary;
    }
    public override string ToString()
    {
        return $"Name:{Name} Surname:{Surname} Id:{EmployeeId} ";
    }

}
