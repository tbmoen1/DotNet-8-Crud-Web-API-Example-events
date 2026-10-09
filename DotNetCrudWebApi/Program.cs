using DotNetCrudWebApi.Data;
using DotNetCrudWebApi.Data.Events;
using DotNetCrudWebApi.Events;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddDbContext<AppDbContext>();
builder.Services.AddTransient<EventCreator>();
builder.Services.AddTransient<EventSubscriber>();

builder.Services.AddControllers();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

    app.UseSwagger();
    app.UseSwaggerUI();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();
app.Run();
