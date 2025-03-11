using Jalasino.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace Jalasino
{
    public partial class EditMeetingForm1 : Form
    {
        private Meeting _meeting;
        private DataContex _context;
        public EditMeetingForm1(Meeting meeting)
        {
            InitializeComponent();
            LoadPeople();
            _context = new DataContex();
            _meeting = _context.Meetings
    .Include(m => m.MeetingPersons)
    .ThenInclude(mp => mp.Person)
    .FirstOrDefault(m => m.Id == meeting.Id);

            // Load existing meeting details into the form
            LoadMeetingDetails();
        }
        private void LoadMeetingDetails()
        {
            txtMeetingTitle.Text = _meeting.Subject;
            dtpickerMeetingDate.SelectedDateInDateTime = _meeting.Date;
            txtMeetingDescription.Text = _meeting.Description;


            // Pre-check persons associated with the meeting
            var meetingPersons = _meeting.MeetingPersons.Select(mp => mp.Person).ToList();
            for (int i = 0; i < chkboxlstPeople.Items.Count; i++)
            {
                var person = (Person)chkboxlstPeople.Items[i];
                    var existingPerson = _context.People.Find(person.Id);
                    if (meetingPersons.Contains(existingPerson))
                        chkboxlstPeople.SetItemChecked(i, true);
            }


           
        }

        private List<Person> _people;
        private void LoadPeople()
        {
            using (var context = new DataContex())
            {
                // Load people from the database
                _people = context.People.ToList();
            }

            // Add people to the checked list box
            foreach (var person in _people)
            {
                chkboxlstPeople.Items.Add(person, false);
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            _meeting.Subject = txtMeetingTitle.Text;
            _meeting.Date = dtpickerMeetingDate.SelectedDateInDateTime;
            _meeting.Description = txtMeetingDescription.Text;


            // Ensure MeetingPersons is initialized
            if (_meeting.MeetingPersons == null)
            {
                _meeting.MeetingPersons = new List<MeetingPerson>();
            }

            // Fetch the currently selected persons from the UI
            var selectedPersons = chkboxlstPeople.CheckedItems.Cast<Person>().ToList();

            // Fetch the existing MeetingPersons from the database
            var existingMeetingPersons = _context.MeetingPersons
                .Where(mp => mp.MeetingId == _meeting.Id)
                .ToList();

            // Determine MeetingPersons to add
            var meetingPersonsToAdd = selectedPersons
                .Where(person => !existingMeetingPersons.Any(mp => mp.PersonId == person.Id))
                .Select(person => new MeetingPerson
                {
                    MeetingId = _meeting.Id,
                    PersonId = person.Id
                })
                .ToList();

            // Determine MeetingPersons to remove
            var meetingPersonsToRemove = existingMeetingPersons
                .Where(mp => !selectedPersons.Any(person => person.Id == mp.PersonId))
                .ToList();

            // Add new MeetingPersons
            foreach (var newMeetingPerson in meetingPersonsToAdd)
            {
                _context.MeetingPersons.Add(newMeetingPerson);
            }

            // Remove outdated MeetingPersons
            foreach (var oldMeetingPerson in meetingPersonsToRemove)
            {
                _context.MeetingPersons.Remove(oldMeetingPerson);
            }


            // Save changes to the database
            _context.Meetings.Update(_meeting);
            _context.SaveChanges();
            MessageBox.Show("Meeting updated successfully!");
            this.DialogResult = DialogResult.OK; // Indicate that the edit was successful
            this.Close();
            
        }

        private void ClearForm()
        {
            txtMeetingTitle.Clear();
            dtpickerMeetingDate.SetTodayDate(BehComponents.PersianDateTime.Now);
            txtMeetingDescription.Clear();
        }

        private void CreateForm_Load(object sender, EventArgs e)
        {
        }
    }
}
