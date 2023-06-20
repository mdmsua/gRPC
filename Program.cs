using Grpc.Net.Client;
using GrpcClient;

using var channel = GrpcChannel.ForAddress("https://dimigrpc.azurewebsites.net");
var client = new Greeter.GreeterClient(channel);
var reply = await client.SayHelloAsync(new HelloRequest { Name = "GreeterClient" });
Console.WriteLine($"Greeting: {reply.Message}");
Console.Read();