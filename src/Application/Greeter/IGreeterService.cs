using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Greeter;

public interface IGreeterService
{
    string SayHello(string name);
}
