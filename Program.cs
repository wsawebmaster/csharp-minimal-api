using MinimalApi.Infraestrutura.Db;
using MinimalApi.DTOs;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<DbContexto>(options =>
{
    options.UseMySql(
        builder.Configuration.GetConnectionString("MySql"), ServerVersion.AutoDetect(builder.Configuration.GetConnectionString("MySql"))
        );
});

var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.MapPost("/login", (MinimalApi.DTOs.LoginDTO loginDTO) =>
{
    if (loginDTO.Email == "admin@teste.com" && loginDTO.Senha == "1234567")
    return Results.Ok("Login comm successo");
    else
        return Results.Unauthorized();
});

app.Run();

public class LoginDTO
{
    public string Email { get; set; } = default!;
    public string Senha { get; set; } = default!;
}