using CompanyDataAccess.Contexts;
using CompanyDataAccess.Interfaces;
using ConsoleProject.Entities;

namespace CompanyDataAccess.Implementations;

public class CompanyRepository : IRepository<Company>
{
    public void Update(Company entity)
    {
        Company company = DBContext.companies.Find(cp=>cp.CompanyId == entity.CompanyId);
        company.Name = entity.Name;
    }
    public Company Get(int id)
    {
        return DBContext.companies.Find(cp => cp.CompanyId == id);
    }
    public void Add(Company entity)
    {
        DBContext.companies.Add(entity);
    }
    public Company GetByName(string name)
    {
        return DBContext.companies.Find(cp => cp.Name == name);
    }

    public void Delete(Company entity)
    {
        DBContext.companies.Remove(entity);
    }
    public List<Company> GetAll()
    {
        return DBContext.companies;
    }

    public List<Company> GetAllByName(string name)
    {
        return DBContext.companies.FindAll(cp => cp.Name == name);
    }

}
