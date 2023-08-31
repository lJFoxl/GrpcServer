using Grpc.Core;
using TestGrpc;

public class TestService : TestGrpcService.TestGrpcServiceBase
{
    public async override Task<TestCommand> GetCommand(TestRequest request, ServerCallContext context)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("��������� ����� �� GRPC �� �������");
        return await Task.FromResult<TestCommand>(new TestCommand()
        {
            Command = "�������� Commanda",
            IsActive = true
        });
    }
}