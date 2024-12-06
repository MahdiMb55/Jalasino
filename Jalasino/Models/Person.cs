using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Jalasino.Models
{
    public class Person
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<ApprovalPerson> ApprovalPersons { get; set; } = new HashSet<ApprovalPerson>();
        public virtual ICollection<MeetingPerson> MeetingPersons { get; set; } = new HashSet<MeetingPerson>();


        public override string ToString()
        {
            return Name;
        }
    }
}
