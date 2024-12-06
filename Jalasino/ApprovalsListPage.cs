using Jalasino.Models;
using Microsoft.EntityFrameworkCore;

namespace Jalasino
{
    public partial class ApprovalsListPage : Form
    {
        private int pageSize = 20;
        private DataContex _context;

        public ApprovalsListPage()
        {
            InitializeComponent();
            _context = new DataContex();
            LoadApprovals();
        }

        private void LoadApprovals()
        {
            object approvals = GetApprovals();
            dataGridViewAllApprovals.DataSource = approvals;
            dataGridViewAllApprovals.Columns["Id"].Visible = false; // Hide Id column
        }

        private object GetApprovals()
        {
            var last20Approvals = _context.Approvals
            .Include(a => a.ApprovalPersons)
                .ThenInclude(ap => ap.Person)
            .Include(a => a.Meeting)
            .OrderByDescending(a => a.Date)
            .Take(pageSize)
            .Select(a=>new
            {
                a.Id,
                meeting = a.Meeting.Subject,
                a.Subject,
                a.Date,
                Persons = string.Join(", ", a.ApprovalPersons.Select(ap => ap.Person.Name)),
                Status = a.Status.ToString()
            })
            .ToList();
            return last20Approvals;
        }



        private void MeetingsListPage_Load(object sender, EventArgs e)
        {

        }
    }
}
