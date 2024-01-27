using gRPC.TaskManagement.BL;
using gRPC.TaskManagement.DAL;
using gRPC.TaskManagement.Presentation.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddGrpc().Services.AddGrpcReflection();
builder.Services
    .AddDALDependences(builder.Configuration)
    .AddBLDependeces();
var app = builder.Build();

// Configure the HTTP request pipeline.
app.MapGrpcService<GreeterService>();
app.MapGrpcService<CategoryService>();
app.MapGrpcService<ProjectService>();
app.MapGrpcReflectionService();
app.MapGet("/", () => "Communication with gRPC endpoints must be made through a gRPC client. To learn how to create a client, visit: https://go.microsoft.com/fwlink/?linkid=2086909");

app.Run();