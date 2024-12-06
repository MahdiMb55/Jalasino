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
        public ApprovalStatus Status { get; set; } = ApprovalStatus.None;
        
        // Foreign key to Meeting
        public int MeetingId { get; set; }

        // Navigation property back to Meeting
        public virtual Meeting Meeting { get; set; } = null!;

        public virtual ICollection<ApprovalPerson> ApprovalPersons { get; set; } = new HashSet<ApprovalPerson>();


    }
}
