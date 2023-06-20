using Grpc.Net.Client;
using GrpcClient;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Console;

var loggerFactory = LoggerFactory.Create(builder => builder.AddFilter("*", LogLevel.Debug).AddConsole());
using var channel = GrpcChannel.ForAddress("https://dimigrpc.azurewebsites.net", new() { LoggerFactory = loggerFactory });
var client = new Greeter.GreeterClient(channel);
var reply = await client.SayHelloAsync(new HelloRequest { Name = "GreeterClient" });
Console.WriteLine($"Greeting: {reply.Message}");
Console.Read();