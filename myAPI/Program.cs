using System;
using System.Reflection.Metadata.Ecma335;

// Create a new web application builder
var builder = WebApplication.CreateBuilder(args);

// Add services to the container
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Build the web application
var app = builder.Build();

// Create a new instance of the NumberChecker class
var numberChecker = new NumberChecker();

// Configure the HTTP request pipeline for development
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// Redirect HTTP requests to HTTPS
app.UseHttpsRedirection();

// Define a route to return "Hello World!"
app.MapGet("/", () => "Hello World!");

// Define a route to return the provided ID
app.MapGet("/{id}", (int id) =>
{
    return $"Hello ID: {id}";
});

// Define a route to check if the provided number is even or odd
app.MapGet("/iseven/{id}", (int id) =>
{
    string status = numberChecker.IsEven(id) ? "Even" : "Odd";
    return $"The number {id} is {status}";
});

// Run the web application
app.Run();

// NumberChecker class
class NumberChecker
{
    public bool IsEven(int number)
    {
        return number % 2 == 0;
    }
}
