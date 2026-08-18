var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World of Github Actions!");

app.Run();

public partial class Program { }