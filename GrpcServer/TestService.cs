using Grpc.Core;
using TestGrpc;

public class TestService : TestGrpcService.TestGrpcServiceBase
{
    public async override Task<TestCommand> GetCommand(TestRequest request, ServerCallContext context)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Формируем ответ по GRPC от сервиса");
        return await Task.FromResult<TestCommand>(new TestCommand()
        {
            Command = "Отличная Commanda",
            IsActive = true
        });
    }
}