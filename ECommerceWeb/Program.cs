var builder = WebApplication.CreateBuilder(args);
builder.Configuration["Urls"] = "http://*:1029"; // Set the URL to use port 1000

var app = builder.Build();

app.MapGet("/", () => "Hello World - e commerce web!");

app.Run();
