using GigaPetProject.Framework.Logging;
using GigaPetProject.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Windows;

namespace GigaPetProject;

/// <summary>
///     Interaction logic for App.xaml
/// </summary>
public partial class App : Application, IDisposable
{
    public delegate string LogDelegate(string message, LogInfo severity);
    public static LogDelegate Log { get; private set; }

    public static ApplicationContext DB { get; private set; }

    private void Application_Startup(object sender, StartupEventArgs e)
    {
        // initialize db context
        DB = new ApplicationContext();

        // initialize loggers by adding them onto Log delegate

        // initialize our window
        var w = new View.MainWindow();
        w.Show();
    }

    public void Dispose()
    {
        DB.Dispose();
        GC.Collect();
        GC.SuppressFinalize(this);
    }
}

public sealed class ApplicationContext : DbContext
{
    private const string DatabasePath = "database.db";

    public DbSet<TODOEntity> Todos { get; private set; } = default!;

    public ApplicationContext()
    {
        Database.Migrate();
        Database.EnsureCreated();
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);
        optionsBuilder.UseSqlite($"Data Source={DatabasePath}");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<Entity>().UseTphMappingStrategy();
    }
}