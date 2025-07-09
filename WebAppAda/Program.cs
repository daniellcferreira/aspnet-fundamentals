using WebAppAda.Middlewares;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.UseMiddleware<AuthMiddlewares>();

app.MapGet("/", () => "Hello World!");

app.Run();
