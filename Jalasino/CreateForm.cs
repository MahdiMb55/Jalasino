using Jalasino.Models;

namespace Jalasino
{
    public partial class CreateForm : Form
    {
        public CreateForm()
        {
            InitializeComponent();
            LoadPeople();
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
            var meeting = new Meeting
            {
                Subject = txtMeetingTitle.Text,
                Date = dtpickerMeetingDate.SelectedDateInDateTime,
                Description = txtMeetingDescription.Text,
                People = new List<Person>()
            };

            // Add selected participants to the meeting
            foreach (Person person in chkboxlstPeople.CheckedItems)
            {
                meeting.People.Add(person);
            }

            using (var context = new DataContex())
            {
                context.Meetings.Add(meeting);
                context.SaveChanges();
            }

            MessageBox.Show("Meeting created successfully!");
            ClearForm();

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
