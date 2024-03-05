namespace ConsoleApplication.CustomExceptions;

public class NoSuitableDriverFound : Exception
{
    public NoSuitableDriverFound(string message) : base(message) { }
}
