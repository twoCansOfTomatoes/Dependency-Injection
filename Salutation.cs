using System;
namespace Dependency_Injection
{
    public class Salutation {
private readonly IMessageWriter _writer;
public Salutation(IMessageWriter writer) {
if(writer == null) {
    throw new ArgumentNullException("writer");
}
_writer = writer;
}
public void Exclaim() {
this._writer.Write("DI Hello!");
}
    }
    
}