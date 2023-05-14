namespace Company.Business.Exceptions;

public class IsNotEmptyException:Exception
{
    public IsNotEmptyException(string message) : base(message) { }
}
