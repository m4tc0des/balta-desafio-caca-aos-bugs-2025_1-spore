using BugStore.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Recupera a string de conexão do appsettings.json
var cnnString = builder.Configuration.GetConnectionString("DefaultConnection");

// Registra o DbContext com SQLite
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlite(cnnString));

var app = builder.Build();

// Rota de teste
app.MapGet("/", () => "Hello World!");

app.Run();