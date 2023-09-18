using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

var builder=WebApplication.CreateBuilder(args);
builder.Configuration
    .AddJsonFile("appsettings.json",true)
    .AddEnvironmentVariables();
var service=builder.Services;
service.AddGrpc();
service.AddGrpcReflection();
var app =builder.Build();
app.UseRouting();
app.UseEndpoints(endpoints =>
{
    endpoints.MapGrpcReflectionService();
    endpoints.MapGrpcService<TestService>();
    endpoints.MapGrpcService<TestService2>();
    endpoints.MapGrpcService<TestService3>();
   
});
app.UseHttpsRedirection();
app.Run();