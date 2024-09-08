using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jalasino.Models
{
    public class Jalase
    {
        public int Id { get; set; }

        [Required]
        public string Subject { get; set; } = null!;
        
        [Required]
        public DateTime Tarikh { get; set; }

        [Required]
        public string Nafarat { get; set; } = null!;

    }
}
