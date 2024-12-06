using Jalasino.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jalasino
{
    public partial class AllMeetingList : Form
    {

        private DataContex _context;
        private const int PageSize = 5;
        private int _currentPage = 1;
        private int _totalPages;


        public AllMeetingList()
        {
            InitializeComponent();
            _context = new DataContex();
        }
        private void LoadMeetings(string searchQuery = "", DateTime? startDate = null, DateTime? endDate = null)
        {
            var meetings = _context.Meetings
    .Include(m => m.MeetingPersons)
    .AsQueryable();

            // Search by subject or description
            if (!string.IsNullOrEmpty(searchQuery))
            {
                meetings = meetings.Where(m => m.Subject.Contains(searchQuery) || m.Description.Contains(searchQuery));
            }

            // Filter by date range
            if (startDate.HasValue)
            {
                meetings = meetings.Where(m => m.Date >= startDate.Value);
            }
            if (endDate.HasValue)
            {
                meetings = meetings.Where(m => m.Date <= endDate.Value);
            }

            // Pagination
            _totalPages = (int)Math.Ceiling(meetings.Count() / (double)PageSize);
            var pagedMeetings = meetings
                .OrderBy(m => m.Date)
                .Skip((PageSize * (_currentPage - 1)))
                .Take(PageSize)
                .Select(m => new
                {
                    m.Id,
                    m.Subject,
                    m.Date,
                    m.Description,
                    Participants = string.Join(", ", m.MeetingPersons.Select(p => p.Person.Name)) // Concatenate participant names
                })
                .ToList();

            // Bind to DataGridView directly
            dataGridViewMeetings.DataSource = pagedMeetings;

            UpdatePaginationControls();
        }

        private void UpdatePaginationControls()
        {
            numericUpDownPage.Value = _currentPage;
            numericUpDownPage.Maximum = _totalPages;
        }

        private void InitializePagination()
        {
            numericUpDownPage.Minimum = 1;
            numericUpDownPage.Value = 1;
            numericUpDownPage.Maximum = _totalPages;
        }

        private void buttonFilter_Click(object sender, EventArgs e)
        {
            string searchQuery = textBoxSearch.Text;
            DateTime? startDate = dateTimePickerStart.Value.Date;
            DateTime? endDate = dateTimePickerEnd.Value.Date.AddDays(1).AddTicks(-1); // To include the end date

            LoadMeetings(searchQuery, startDate, endDate);
        }

        private void numericUpDownPage_ValueChanged(object sender, EventArgs e)
        {
            _currentPage = (int)numericUpDownPage.Value;
            LoadMeetings();
        }

        private void dataGridViewMeetings_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && e.RowIndex >= 0)
            {
                dataGridViewMeetings.ClearSelection();
                dataGridViewMeetings.Rows[e.RowIndex].Selected = true;

                var contextMenu = new ContextMenuStrip();
                var editMenuItem = new ToolStripMenuItem("Edit");
                var deleteMenuItem = new ToolStripMenuItem("Delete");

                editMenuItem.Click += (s, ea) => EditMeeting(_context.Meetings.Where(m => m.Id == (int)dataGridViewMeetings.SelectedRows[0].Cells["Id"].Value).First());
                deleteMenuItem.Click += (s, ea) => DeleteMeeting(_context.Meetings.Where(m => m.Id == (int)dataGridViewMeetings.SelectedRows[0].Cells["Id"].Value).First());

                contextMenu.Items.AddRange(new ToolStripItem[] { editMenuItem, deleteMenuItem });
                contextMenu.Show(dataGridViewMeetings, MousePosition.X-600,MousePosition.Y-300 );
            }
        }

        private void EditMeeting(Meeting meeting)
        {
            using (var editForm = new EditMeetingForm(meeting))
            {
                if (editForm.ShowDialog() == DialogResult.OK)
                {
                    // Reload the meetings after editing
                    LoadMeetings();
                }
            }
        }

        private void DeleteMeeting(Meeting meeting)
        {
            var confirmResult = MessageBox.Show($"Are you sure to delete this meeting: {meeting.Subject}?", "Confirm Delete", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                _context.Meetings.Remove(meeting);
                _context.SaveChanges();
                LoadMeetings();
            }
        }

        private void AllMeetingList_Load_1(object sender, EventArgs e)
        {
            LoadMeetings();
            InitializePagination();
        }
    }
}
