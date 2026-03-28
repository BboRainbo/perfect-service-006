using Application.Greeter;
using Grpc.Core;
using Web;

namespace Web.Services;

public class GreeterService : Greeter.GreeterBase
{
    private readonly IGreeterService _greeter;

    public GreeterService(IGreeterService greeter)
    {
        _greeter = greeter;
    }

    public override Task<HelloReply> SayHello(HelloRequest request, ServerCallContext context)
    {
        var message = _greeter.SayHello(request.Name);
        return Task.FromResult(new HelloReply { Message = message });
    }
}