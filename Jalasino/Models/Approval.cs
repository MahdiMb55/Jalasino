using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jalasino.Models
{
    public class Approval
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Subject { get; set; } = null!;

        [Required]
        public DateTime Date { get; set; }

        [Required]
        public string Actioner { get; set; } = null!;

        [Required]
        public string Status { get; set; } = null!;

    }
}
