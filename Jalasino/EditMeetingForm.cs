using Jalasino.Models;
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
    public partial class EditMeetingForm : Form
    {
        private Meeting _meeting;
        private DataContex _context;

        public EditMeetingForm(Meeting meeting)
        {
            InitializeComponent();
            _meeting = meeting;
            _context = new DataContex();

            // Load existing meeting details into the form
            LoadMeetingDetails();
        }

        private void LoadMeetingDetails()
        {
            textBoxSubject.Text = _meeting.Subject;
            dateTimePickerDate.Value = _meeting.Date;
            textBoxDescription.Text = _meeting.Description;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            // Update meeting details
            _meeting.Subject = textBoxSubject.Text;
            _meeting.Date = dateTimePickerDate.Value;
            _meeting.Description = textBoxDescription.Text;

            // Save changes to the database
            _context.Meetings.Update(_meeting);
            _context.SaveChanges();

            MessageBox.Show("Meeting updated successfully!");
            this.DialogResult = DialogResult.OK; // Indicate that the edit was successful
            this.Close();
        }

        private void EditMeetingForm_Load(object sender, EventArgs e)
        {

        }
    }
}
