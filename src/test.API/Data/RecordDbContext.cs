using Microsoft.EntityFrameworkCore;
using test.API.Models;
using Task = test.API.Models.Task;

namespace test.API.Data;

public class RecordDbContext: DbContext
{
    public RecordDbContext(DbContextOptions<RecordDbContext> options) : base(options)
    {
    }

    public DbSet<Language> Languages { get; set; }
    public DbSet<Record> Records { get; set; }
    public DbSet<Student> Students { get; set; }
    public DbSet<Task> Tasks { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {

        modelBuilder.Entity<Record>()
            .HasOne(r => r.Language)
            .WithMany()
            .HasForeignKey(r => r.LanguageId)
            .OnDelete(DeleteBehavior.Restrict);
        
        modelBuilder.Entity<Record>()
            .HasOne(r => r.Task)
            .WithMany()
            .HasForeignKey(r => r.TaskId)
            .OnDelete(DeleteBehavior.Restrict);
        
        modelBuilder.Entity<Record>()
            .HasOne(r => r.Student)
            .WithMany()
            .HasForeignKey(r => r.StudentId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}