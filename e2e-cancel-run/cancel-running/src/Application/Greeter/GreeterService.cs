using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Greeter;

public class GreeterService : IGreeterService
{
    public string SayHello(string name)
        => $"Hello {name} (from Application Layer)";
}
