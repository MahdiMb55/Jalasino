using Jalasino.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jalasino
{
    public class DataContex:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source = UserData.db");
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Meeting> Meetings { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Add seed data
            modelBuilder.Entity<Meeting>().HasData(
                new Meeting { Id = 1, Subject = "Project Kickoff", Date = DateTime.Now.AddDays(-1), People = "Alice, Bob" },
                new Meeting { Id = 2, Subject = "Daily Standup", Date = DateTime.Now.AddDays(0), People = "Team A" },
                new Meeting { Id = 3, Subject = "Sprint Planning", Date = DateTime.Now.AddDays(1), People = "Team B" }
            );
        }
    }
}