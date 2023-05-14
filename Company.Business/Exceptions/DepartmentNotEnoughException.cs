namespace Company.Business.Exceptions;

public class DepartmentNotEnoughException:Exception
{
    public DepartmentNotEnoughException(string message):base(message)
    {
        
    }
}
