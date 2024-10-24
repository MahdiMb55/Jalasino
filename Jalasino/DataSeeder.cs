using Jalasino.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jalasino
{
    public class DataSeeder
    {
        public static void Seed(DataContex context)
        {
            // Ensure the database is created
            context.Database.EnsureCreated();


            // Seed people if they don't exist
            if (!context.People.Any())
            {
                var people = new List<Person>
            {
                new Person { Name = "Alice Johnson" },
                new Person { Name = "Bob Smith" },
                new Person { Name = "Charlie Brown" },
                new Person { Name = "Diana Prince" }
            };

                context.People.AddRange(people);
                context.SaveChanges(); // Save to generate IDs for relationships
            }

            // Seed meetings if they don't exist
            if (!context.Meetings.Any())
            {
                var meetings = new List<Meeting>
            {
                new Meeting
                {
                    Subject = "Project Kickoff",
                    Date = new DateTime(2024, 10, 30, 10, 0, 0),
                    Description = "Initial meeting to discuss the project kickoff.",
                    People = new List<Person>
                    {
                        context.People.First(p => p.Name == "Alice Johnson"),
                        context.People.First(p => p.Name == "Bob Smith")
                    }
                },
                new Meeting
                {
                    Subject = "Weekly Sync",
                    Date = new DateTime(2024, 11, 6, 15, 0, 0),
                    Description = "Weekly sync-up to discuss project progress.",
                    People = new List<Person>
                    {
                        context.People.First(p => p.Name == "Bob Smith"),
                        context.People.First(p => p.Name == "Charlie Brown")
                    }
                },
                new Meeting
                {
                    Subject = "Budget Review",
                    Date = new DateTime(2024, 11, 13, 9, 0, 0),
                    Description = "Review the budget allocation for the next quarter.",
                    People = new List<Person>
                    {
                        context.People.First(p => p.Name == "Alice Johnson"),
                        context.People.First(p => p.Name == "Diana Prince")
                    }
                }
            };

                context.Meetings.AddRange(meetings);
                context.SaveChanges();
            }
        }
    }
}
