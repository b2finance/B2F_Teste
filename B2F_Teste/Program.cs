using B2F_Teste;
using System.Diagnostics;


var builder = Host.CreateApplicationBuilder(args);
builder.Services.AddHostedService<Worker>();
await Squirrel.TryApplyUpdates();


var host = builder.Build();
host.Run();
