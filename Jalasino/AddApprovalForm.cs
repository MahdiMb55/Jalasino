using Jalasino.Models;
using System;
using System.Windows.Forms;

namespace Jalasino
{
    public partial class AddApprovalForm : Form
    {
        public AddApprovalForm()
        {
            InitializeComponent();
            LoadApprovalStatus();
            LoadPeople();

        }
        public Meeting meeting;
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
                chklstboxActioners.Items.Add(person, false);
            }
        }
        private void buttonSave_Click(object sender, EventArgs e)
        {
            // Validation
            if (string.IsNullOrWhiteSpace(textBoxSubject.Text) ||
                chklstboxActioners.CheckedItems.Count == 0 ||
                string.IsNullOrWhiteSpace(ComboStatus.Text))
            {
                MessageBox.Show("Please fill in all required fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Create a new Approval object
            var newApproval = new Approval
            {
                Subject = textBoxSubject.Text,
                Date = dateTimePickerDate.SelectedDateInDateTime,
                ApprovalPersons = new List<ApprovalPerson>(),
                Status = (ApprovalStatus)ComboStatus.SelectedIndex,
                MeetingId = meeting.Id
            };
            // Add selected participants to the meeting
            foreach (Person person in chklstboxActioners.CheckedItems)
            {
                newApproval.ApprovalPersons.Add(new ApprovalPerson { PersonId= person.Id} );
            }


            // Save the new approval to the database
            using (var context = new DataContex())
            {
                context.Approvals.Add(newApproval);
                context.SaveChanges();
            }

            // Confirmation message
            MessageBox.Show("Approval added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void AddApprovalForm_Load(object sender, EventArgs e)
        {

        }

        private void LoadApprovalStatus()
        {
            ComboStatus.Items.Add("تعریف نشده");
            ComboStatus.Items.Add("تایید شده");
            ComboStatus.Items.Add("ثبت شده");
            ComboStatus.Items.Add("انجام شده");
            ComboStatus.Items.Add("انجام نشده");
            ComboStatus.SelectedIndex = 2;

        }
    }
}
