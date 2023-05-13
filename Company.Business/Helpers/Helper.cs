namespace Company.Business.Helpers;

public static class Helper
{
  public static Dictionary<string, string> errors = new Dictionary<string, string>()
  {
      {"AlreadyExistException","This object already exist" },
      {"SizeException","Length doesn't " }
  };
}
