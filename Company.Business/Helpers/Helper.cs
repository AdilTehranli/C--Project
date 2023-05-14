namespace Company.Business.Helpers;

public static class Helper
{
  public static Dictionary<string, string> errors = new Dictionary<string, string>()
  {
      {"AlreadyExistException","This object already exist" },
      {"SizeException","Length doesn't " },
      {"NotValidWordException","Entered word is not valid. Use only letters" },
      {"DepartmentNotEnoughException","Department is already full"}
  };
}
