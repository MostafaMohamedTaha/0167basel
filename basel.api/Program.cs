#region import
using basel.core;
using basel.infra;
using basel.service;
using Microsoft.EntityFrameworkCore;
using Scalar.AspNetCore;
using static basel.infra.Context.BaselAppContext;
#endregion

#region default service


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();
#endregion

#region connection string

    var connection = builder.Configuration.GetConnectionString("DefaultConnection");

    builder.Services.AddDbContext<BaselDbContext>(opt => opt.UseSqlServer(connection));
#endregion

#region add module
builder.Services.AddOpenApi();
builder.Services.AddInfra()
                .AddService()
                .AddCore();


#endregion

#region default app use
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapScalarApiReference();
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
#endregion
