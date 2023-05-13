using System.Reflection;

namespace Company.Business.Exceptions;

public class AlreadyExistException:Exception
{
    public AlreadyExistException(string message):base(message   )
    {
        
    }
}
