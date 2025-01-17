using Master.Rotas.API.Configuration;
using Master.Rotas.Configuration;

var builder = WebApplication.CreateBuilder(args);
var configuration = builder.Configuration;

configuration
        .SetBasePath(Directory.GetCurrentDirectory())
        .AddJsonFile("appsettings.json", false, false)
        .AddJsonFile($@"appsettings.{builder.Environment.EnvironmentName}.json", false, false)
        .AddCommandLine(args)
        .AddEnvironmentVariables()
        .AddUserSecrets(typeof(Program).Assembly).Build();


builder.Services.AddApiConfiguration(configuration);
builder.Services.AddIdentityConfiguration(configuration);
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

builder.Services.AddEndpointsApiExplorer();
builder.Services.ResolveDependencies();
builder.Services.AddApiConfiguration(configuration);
builder.Services.AddSwaggerConfiguration();

var app = builder.Build();
var environment = app.Environment;

app.UseApiConfiguration(app.Environment);
app.UseSwaggerConfiguration();



app.Run();