

using Company.Business.Interfaces;
namespace Company.Business.Services;

using Company.Business.Exceptions;
using Company.Business.Helpers;
using CompanyDataAccess.Contexts;
using CompanyDataAccess.Implementations;
using ConsoleProject.Entities;

public class CompanyService : ICompanyService
{
    public CompanyRepository companyrepository { get; }
    public CompanyService()
    {
        companyrepository = new CompanyRepository();
    }
    public void Create(string companyName)

    {
        var exist = companyrepository.GetByName(companyName);
        if (exist != null)
        {
            throw new AlreadyExistException(Helper.errors["AlreadyExistException"]);
        }
        string name = companyName.Trim();
        if (name.Length < 2)
        {
            throw new SizeException(Helper.errors["SizeException"]);
        }
        Company company = new Company(companyName);
        companyrepository.Add(company);
    }

    public void Delete(string name)
    {
        DBContext.companies.Find(cp=>cp.Name == name);
        throw new NotFoundException("such a company does not not exist");
    }

    public List<Company> GetAll()
    {
        return DBContext.companies();
    }

    public Company GetById(int id)
    {
        var count = DBContext.companies.Count();
        if(count>id)
        {
            throw new NotFoundException("bo such id");
        }
        else
        {
            return DBContext.companies.Find(cmp => cmp.CompanyId == id);
        }
    }
}
