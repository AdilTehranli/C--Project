

using Company.Business.Interfaces;
namespace Company.Business.Services;

using Company.Business.Exceptions;
using Company.Business.Helpers;
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
            throw new AlreadyExistException(Helper.errors["AlreadyExistException"]);
        }
        string word=name.Trim();
        if (word.Length <= 2)
        {
            throw new SizeException(Helper.errors["SizeException"]);
        }
        Company company = new Company(word);
        CompanyRepository.Add(company);
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
