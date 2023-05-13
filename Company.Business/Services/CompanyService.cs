

using Company.Business.Interfaces;
namespace Company.Business.Services;

using Company.Business.Exceptions;
using CompanyDataAccess.Implementations;
using ConsoleProject.Entities;

public class CompanyService : ICompanyService
{
    public CompanyRepository CompanyRepository { get;}
    public CompanyService()
    {
        CompanyRepository = new CompanyRepository();
    }
    public void Create(string name)
    {
        var exist=CompanyRepository.GetByName(name);
        if (exist != null) 
             {
            throw new AlreadyExistException("");
        }
    }

    public void Delete(string name)
    {
        throw new NotImplementedException();
    }

    public List<Company> GetAll()
    {
        throw new NotImplementedException();
    }

    public void GetById(int id)
    {
        throw new NotImplementedException();
    }

    public void GetByName(string name)
    {
        throw new NotImplementedException();
    }
}
