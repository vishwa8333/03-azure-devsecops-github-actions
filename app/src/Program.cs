var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => Results.Ok(new
{
    service = "azure-devsecops-api",
    status = "healthy",
    version = "1.0.0"
}));

app.MapGet("/health", () => Results.Ok("healthy"));

app.Run();

