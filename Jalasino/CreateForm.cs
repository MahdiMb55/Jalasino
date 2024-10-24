using System;
using System.Windows.Forms;

namespace Jalasino
{
    public partial class CreateForm : Form
    {
        public CreateForm()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string title = txtMeetingTitle.Text;
            string dateText = txtMeetingDate.Text;
            string description = txtMeetingDescription.Text;

            if (DateTime.TryParse(dateText, out DateTime date))
            {
                // Logic to save the meeting, e.g., adding it to a list or a database
                MessageBox.Show("Meeting Created Successfully!");
                ClearForm();
            }
            else
            {
                MessageBox.Show("Invalid date format. Please enter a valid date.");
            }
        }

        private void ClearForm()
        {
            txtMeetingTitle.Clear();
            txtMeetingDate.Clear();
            txtMeetingDescription.Clear();
        }
    }
}
