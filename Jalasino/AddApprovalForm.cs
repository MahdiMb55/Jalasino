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
                chklstboxActioners.Items.Add(person, false);
            }
        }
        private void buttonSave_Click(object sender, EventArgs e)
        {
            // Validation
            if (string.IsNullOrWhiteSpace(textBoxSubject.Text) ||
                chklstboxActioners.CheckedItems.Count == 0 ||
                string.IsNullOrWhiteSpace(textBoxStatus.Text))
            {
                MessageBox.Show("Please fill in all required fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Create a new Approval object
            var newApproval = new Approval
            {
                Subject = textBoxSubject.Text,
                Date = dateTimePickerDate.SelectedDateInDateTime,
                Actioners = new List<Person>(),
                Status = textBoxStatus.Text
            };
            // Add selected participants to the meeting
            foreach (Person person in chklstboxActioners.CheckedItems)
            {
                newApproval.Actioners.Add(person);
            }


            // Save the new approval to the database
            using (var context = new DataContex())
            {
                context.Approvals.Add(newApproval);
                context.SaveChanges();
            }

            // Confirmation message
            MessageBox.Show("Approval added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Close the form
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
