using Jalasino.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Jalasino
{
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
            LoadPendingMeetings();
        }

        public void LoadPendingMeetings(object meeting = null )
        {
            if (meeting==null)
                meeting = GetMeetings().Where(m => m.Date < DateTime.Today).ToList();
            
            dataGridViewMeetings.DataSource = meeting;
        }

        private List<Meeting> GetMeetings()
        {
            // Simulate fetching data from a data source.
            return new List<Meeting>
            {
            };
        }

        private void MainPage_Load(object sender, EventArgs e)
        {

        }
    }
}
