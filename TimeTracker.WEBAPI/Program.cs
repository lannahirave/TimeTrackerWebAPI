using Microsoft.EntityFrameworkCore;
using TimeTracker.DAL.Context;
using TimeTracker.Extensions;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<TimeTrackerContext>(option =>
    option.UseSqlServer(builder.Configuration.GetConnectionString("TimeTrackerDB")));
//Custom services
builder.Services.AddAutoMapper();
builder.Services.RegisterCustomServices();
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