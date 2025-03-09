using Microsoft.AspNetCore.Cors.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Online_Learning_Project;
using System.Text.Json.Serialization;

namespace OnlineLearningPlatform;

// Install-Package Microsoft.Extensions.Configuration.Json
// Install-Package Microsoft.EntityFrameworkCore
// Install-Package Microsoft.EntityFrameworkCore.SqlServer
// Install-Package Microsoft.EntityFrameworkCore.Design
// Install-Package Microsoft.EntityFrameworkCore.Tools

// Creating Migration: 
// Add-Migration InitialMigration

// Updating the database with the last migration:
// Update-Database

// Display a list of all migrations: 
// Get-Migration

// Create a SQL file containing all commands for building the database: 
// Script-Migration -Output Migrations/GiftShop.sql

// Revert back to specific migration: 
// Update-Database InitialMigration

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);
        builder.Services.AddScoped<UserService>();
        builder.Services.AddScoped<CourseService>();
        builder.Services.AddScoped<LessonService>();
        builder.Services.AddScoped<EnrollmentService>();
        builder.Services.AddScoped<ProgressService>();

        builder.Services.AddDbContext<ApplicationDbContext>(options =>
        {
            // Use the static property from AppConfig
            options.UseSqlServer(AppConfig.ConnectionString);
        });


        builder.Services.AddControllers()
            .AddJsonOptions(options => options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles)
            .AddJsonOptions(options => options.JsonSerializerOptions.DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull);


        var app = builder.Build();

        app.MapControllers();
        app.Run();

    }
}
