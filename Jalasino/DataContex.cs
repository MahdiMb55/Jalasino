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
        public DbSet<Jalase> Jalasat { get; set; }
    }
}