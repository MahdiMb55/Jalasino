﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jalasino.Models
{
    public class Meeting
    {
        [Key]
        public int Id { get; set; }

        public string Subject { get; set; } = null!;
        
        public string Description { get; set; } = null!;
        
        public DateTime Date { get; set; }

        public List<Person> People { get; set; } = new List<Person>();

    }
}
