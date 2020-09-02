using System;
namespace Dependency_Injection {
public interface IMessageWriter {
    void Write(string message);
}
public class ConsoleMessageWriter : IMessageWriter
{
    public void Write(string message)
    {
        Console.WriteLine(message);
    }
}
}
