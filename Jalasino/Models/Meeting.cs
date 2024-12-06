using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Jalasino.Models
{
    public class Meeting
    {
        [Key]
        public int Id { get; set; }

        public string Subject { get; set; } = null!;
        
        public string Description { get; set; } = null!;
        
        public DateTime Date { get; set; }

        public virtual ICollection<MeetingPerson> MeetingPersons { get; set; } = new HashSet<MeetingPerson>();


        public virtual ICollection<Approval> Approvals { get; set; } = new HashSet<Approval>();

    }
}
