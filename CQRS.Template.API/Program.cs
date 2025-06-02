using CQRS.Template.Infrastructure.Persistence;
using CQRS.Template.Infrastructure.Repositories;
using CQRS.Template.Application.Interfaces;
using Microsoft.EntityFrameworkCore;
using FluentValidation;
using System.Reflection;
using MediatR;

var builder = WebApplication.CreateBuilder(args);

// Add Controllers
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Register MediatR
builder.Services.AddMediatR(Assembly.Load("CQRS.Template.Application"));

// Register FluentValidation
builder.Services.AddValidatorsFromAssembly(Assembly.Load("CQRS.Template.Application"));

// Register AppDbContext with SQLite
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection")));

// Register Repositories
builder.Services.AddScoped<IUserRepository, UserRepository>();

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();

app.MapControllers();

app.Run();
