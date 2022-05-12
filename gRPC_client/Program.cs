using Grpc.Net.Client;
using GrpcService1;




using (var channel = GrpcChannel.ForAddress("https://localhost:7231"))
{
    var client = new Greeter.GreeterClient(channel);
    var reply = await client.SayHelloAsync(new HelloRequest
    {
        Name = "Emilio"
    });
    Console.WriteLine(reply.Message);
}