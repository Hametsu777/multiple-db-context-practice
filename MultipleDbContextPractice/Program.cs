using Microsoft.EntityFrameworkCore;
using MultipleDbContextPractice.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// When using mulitple DBs, have to specify which one to use when doing migrations using EF. Need to add
// -- context (Name of DB goes here) to migration command. Command looks like dotnet ef migrations add InitialCreate --context DBName
// When adding migration, UserDb migration has created another character table since there is a relationship established between them.
builder.Services.AddDbContext<UserDbContext>(options =>
        options.UseNpgsql(builder.Configuration.GetConnectionString("UserConnection")));
builder.Services.AddDbContext<CharacterDbContext>(options =>
        options.UseNpgsql(builder.Configuration.GetConnectionString("CharacterConnection")));

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
