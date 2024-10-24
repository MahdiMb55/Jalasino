using Jalasino.Models;
using Microsoft.EntityFrameworkCore;

namespace Jalasino
{
    public class DataContex : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source = UserData.db");
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Meeting> Meetings { get; set; }
        public DbSet<Person> People { get; set; }
        public DbSet<Approval> Approvals { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Add seed data
            modelBuilder.Entity<Person>().ToTable("People").HasData(
                new Person { Id = 1, Name = "Alice" },
                new Person { Id = 2, Name = "Bob" },
                new Person { Id = 3, Name = "Charlie" },
                new Person { Id = 4, Name = "David" },
                new Person { Id = 5, Name = "Eve" }
            );

            // Seed Meetings (assuming these participants already exist in the database)
            modelBuilder.Entity<Meeting>().ToTable("Meetings").HasData(
                new Meeting
                {
                    Id = 1,
                    Subject = "Project Kickoff",
                    Date = new DateTime(2024, 10, 30, 10, 0, 0),
                    Description = "Initial meeting to discuss the project kickoff.",
                },
                new Meeting
                {
                    Id = 2,
                    Subject = "Weekly Sync",
                    Date = new DateTime(2024, 11, 6, 15, 0, 0),
                    Description = "Weekly sync-up to discuss project progress.",
                },
                new Meeting
                {
                    Id = 3,
                    Subject = "Budget Review",
                    Date = new DateTime(2024, 11, 13, 9, 0, 0),
                    Description = "Review the budget allocation for the next quarter.",
                }
            );
        }
    }
}