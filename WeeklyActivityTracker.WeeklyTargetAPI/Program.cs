/*
 * AUTHOR: Sam Maxwell
 * DATE CREATED: 12/10/2024
 * 
 * DESCRIPTION: The main program file for the Weekly Activity Tracker application backend.
 */

using Microsoft.EntityFrameworkCore;
using WeeklyActivityTracker.Data.WeeklyTarget;

var builder = WebApplication.CreateBuilder(args);

// Adding database context
builder.Services.AddDbContext<WeeklyTargetDbContext>(options =>
{
    options.UseNpgsql(builder.Configuration.GetConnectionString("WeeklyTarget"));
});

// Add services to the container
builder.Services.AddScoped<IWeeklyTargetDataLayer, WeeklyTargetDataLayer>();

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
