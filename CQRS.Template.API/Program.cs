using MediatR;
using FluentValidation;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Register MediatR
builder.Services.AddMediatR(Assembly.Load("CQRS.Template.Application"));

// Register FluentValidation
builder.Services.AddValidatorsFromAssembly(Assembly.Load("CQRS.Template.Application"));

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();

app.MapControllers();

app.Run();
