using InventoryService.Infrastructure;
using InventoryService.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddSwaggerGen();
AddDependencyInjection(builder.Services);
AddDatabaseConnection(builder);

var app = builder.Build();

// Configure the HTTP request pipeline.
app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.UseSwagger();
app.UseSwaggerUI();

app.Run();

void AddDependencyInjection(IServiceCollection services)
{
    services.AddSingleton<IItemService, ItemService>();
    services.AddSingleton<IItemRepository, ItemRepository>();
}

void AddDatabaseConnection(WebApplicationBuilder? builder)
{
    string? azureConnectionString = builder?.Configuration.GetConnectionString("AzureDatabase");
    DatabaseConnectionString.ConnectionString = azureConnectionString;
}