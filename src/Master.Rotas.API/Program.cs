<<<<<<<< HEAD:src/Master.Rotas/Program.cs
using Master.Rotas.API.Configuration;
========
// using Master.Rotas.API.Configuration;
>>>>>>>> develop:src/Master.Rotas.API/Program.cs

var builder = WebApplication.CreateBuilder(args);
var configuration = builder.Configuration;

configuration
        .SetBasePath(Directory.GetCurrentDirectory())
        .AddJsonFile("appsettings.json", false, false)
        .AddJsonFile($@"appsettings.{builder.Environment.EnvironmentName}.json", false, false)
        .AddCommandLine(args)
        .AddEnvironmentVariables()
        .AddUserSecrets(typeof(Program).Assembly).Build();

// builder.Services.AddApiConfiguration(configuration);
builder.Services.AddEndpointsApiExplorer();
// builder.Services.AddSwaggerConfiguration();

var app = builder.Build();
var environment = app.Environment;

// app.UseSwaggerConfiguration();
// app.UseApiConfiguration(environment);

app.Run();