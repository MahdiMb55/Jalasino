using Jalasino.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Jalasino
{
    public partial class MeetingsListPage : Form
    {
        private int currentPage = 1;
        private int pageSize = 20;

        public MeetingsListPage()
        {
            InitializeComponent();
            LoadMeetings(currentPage);
        }

        private void LoadMeetings(int page)
        {
            List<Meeting> meetings = GetMeetings();
            int skip = (page - 1) * pageSize;
            var paginatedMeetings = meetings.Skip(skip).Take(pageSize).ToList();
            dataGridViewAllMeetings.DataSource = paginatedMeetings;
        }

        private List<Meeting> GetMeetings()
        {
            return new List<Meeting>
            {
              };
        }

        private void btnNextPage_Click(object sender, EventArgs e)
        {
            currentPage++;
            LoadMeetings(currentPage);
        }

        private void btnPreviousPage_Click(object sender, EventArgs e)
        {
            if (currentPage > 1)
            {
                currentPage--;
                LoadMeetings(currentPage);
            }
        }

        private void MeetingsListPage_Load(object sender, EventArgs e)
        {

        }
    }
}
