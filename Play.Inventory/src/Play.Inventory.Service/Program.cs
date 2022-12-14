using Play.Common.MongoDB;
using Play.Inventory.Service.Models;
using Play.Inventory.Service.Clients;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddMongo().AddMongoRepository<InventoryItem>("inventoryitems");

builder.Services.AddHttpClient<CatalogClient>(client =>
{
    client.BaseAddress = new Uri("https://localhost:7074");
});

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
