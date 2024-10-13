/*
 * AUTHOR: Sam Maxwell
 * DATE CREATED: 13/10/2024
 * 
 * DESCRIPTION: An initialisation container that applies the database migrations for the Weekly Target database.
 */

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using WeeklyActivityTracker.Data.WeeklyTarget;
using WeeklyActivityTracker.WeeklyTargetAPI.InitDatabase;

// PROGRAM CONFIGURATION
IHost host = Host.CreateDefaultBuilder(args)
    .ConfigureServices((context, services) =>
    {
        // Adding database context
        services.AddDbContext<WeeklyTargetDbContext>(options =>
        {
            options.UseNpgsql(context.Configuration.GetConnectionString("WeeklyTarget"), b => b.MigrationsAssembly("WeeklyActivityTracker.WeeklyTargetAPI.InitDatabase"));
        });

        // Adding required services
        services.AddScoped<IWeeklyTargetDataLayer, WeeklyTargetDataLayer>();

        // Adding main service
        services.AddTransient<MigrationApplicator>();
    })
    .Build();

// MAIN CODE EXECUTION
MigrationApplicator migrationApplicator = host.Services.GetRequiredService<MigrationApplicator>();
migrationApplicator.ApplyMigrations();
