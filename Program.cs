using Microsoft.OpenApi.Models;
using Microsoft.EntityFrameworkCore;
using Pizzéria.Models;

var builder = WebApplication.CreateBuilder(args);

// Configuration de la chaîne de connexion SQLite
var connectionString = builder.Configuration.GetConnectionString("Pizzas") ?? "Data Source=Pizzas.db";

// Ajout du contexte de base de données EF Core avec SQLite
builder.Services.AddDbContext<PizzaEhodDB>(options =>
    options.UseSqlite(connectionString));

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo
    {
        Title = " API Pizzéria ",
        Description = " Faire les pizzas que vous aimez ",
        Version = "v1"
    });
});

var app = builder.Build();
app.UseSwagger();
app.UseSwaggerUI(c =>
{
    c.SwaggerEndpoint("/swagger/v1/swagger.json", "Pizzéria API V1");
});

app.MapGet("/", () => " Ecole Supérieure Polytechnique DIT2 2024");

app.MapGet("/pizzas", async (PizzaEhodDB db) => await db.Pizzas.ToListAsync());

app.MapGet("/pizzas/{id}", async (PizzaEhodDB db, int id) =>
{
    var pizza = await db.Pizzas.FindAsync(id);
    return pizza != null ? Results.Ok(pizza) : Results.NotFound();
});

app.MapPost("/pizzas", async (PizzaEhodDB db, PizzaEhod pizza) =>
{
    await db.Pizzas.AddAsync(pizza);
    await db.SaveChangesAsync();
    return Results.Created($"/pizzas/{pizza.IdEhod}", pizza);
});

app.MapPut("/pizzas/{id}", async (PizzaEhodDB db, int id, PizzaEhod updatedPizza) =>
{
    var pizza = await db.Pizzas.FindAsync(id);
    if (pizza == null) return Results.NotFound();

    pizza.NomEhod = updatedPizza.NomEhod;
    pizza.DescriptionEhod = updatedPizza.DescriptionEhod;

    await db.SaveChangesAsync();
    return Results.NoContent();
});

app.MapDelete("/pizzas/{id}", async (PizzaEhodDB db, int id) =>
{
    var pizza = await db.Pizzas.FindAsync(id);
    if (pizza == null) return Results.NotFound();

    db.Pizzas.Remove(pizza);
    await db.SaveChangesAsync();
    return Results.Ok();
});

app.Run();