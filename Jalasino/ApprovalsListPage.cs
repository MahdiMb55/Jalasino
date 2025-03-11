using Jalasino.Models;
using Microsoft.EntityFrameworkCore;
using System.Globalization;

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

            dataGridViewAllApprovals.Columns["meeting"].HeaderText = "موضوع جلسه";
            dataGridViewAllApprovals.Columns["Subject"].HeaderText = "موضوع مصوبه";
            dataGridViewAllApprovals.Columns["Date"].HeaderText = "تاریخ";
            dataGridViewAllApprovals.Columns["Persons"].HeaderText = "افراد";
            dataGridViewAllApprovals.Columns["Status"].HeaderText = "وضعیت";

        }
        private string ConvertToShamsi(DateTime date)
        {
            PersianCalendar pc = new PersianCalendar();
            return $"{pc.GetYear(date)}/{pc.GetMonth(date):00}/{pc.GetDayOfMonth(date):00}";
        }
        private object GetApprovals()
        {
            var last20Approvals = _context.Approvals
            .Include(a => a.ApprovalPersons)
                .ThenInclude(ap => ap.Person)
            .Include(a => a.Meeting)
            .OrderByDescending(a => a.Date)
            .Take(pageSize)
            .AsEnumerable() // انتقال داده به حافظه برای اجرای توابع C#
            .Select(a=>new
            {
                a.Id,
                meeting = a.Meeting.Subject,
                a.Subject,
                Date = ConvertToShamsi(a.Date),
                Persons = string.Join(", ", a.ApprovalPersons.Select(ap => ap.Person.Name)),
                Status = a.Status.GetDescription()
            })
            .ToList();
            return last20Approvals;
        }

        private void MeetingsListPage_Load(object sender, EventArgs e)
        {

        }
    }
}
