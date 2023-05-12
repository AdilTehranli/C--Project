using CompanyDataAccess.Contexts;
using CompanyDataAccess.Interfaces;
using ConsoleProject.Entities;

namespace CompanyDataAccess.Implementations;

public class DepartmentRepository : IRepository<Department>
{
    public void Add(Department entity)
    {
        DBContext.departments.Add(entity);
    }

    public Department Get(int id)
    {
        return DBContext.departments.Find(dp=>dp.DepartmentId==id);
    }
    public void Update(Department entity)
    {
        Department department= DBContext.departments.Find(dp => dp.DepartmentId == entity.DepartmentId);
        department.Name = entity.Name;
    }
    public List<Department> GetAll()
    {
        return DBContext.departments;
    }

}
