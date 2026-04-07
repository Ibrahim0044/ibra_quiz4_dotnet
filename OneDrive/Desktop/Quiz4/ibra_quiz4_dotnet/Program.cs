var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Database access has already been done on April 6, 2026 by Ibrahim Patel");

app.Run();