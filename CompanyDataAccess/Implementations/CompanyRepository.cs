using CompanyDataAccess.Contexts;
using CompanyDataAccess.Interfaces;
using ConsoleProject.Entities;

namespace CompanyDataAccess.Implementations;

public class CompanyRepository : IRepository<Company>
{
    public void Add(Company entity)
    {
        DBContext.companies.Add(entity);
    }
    public void Update(Company entity)
    {
        Company company = DBContext.companies.Find(cp=>cp.CompanyId == entity.CompanyId);
        company.Name = entity.Name;
    }
    public Company Get(int id)
    {
        return DBContext.companies.Find(cp => cp.CompanyId == id);
    }

    public List<Company> GetAll()
    {
        return DBContext.companies;
    }

}
