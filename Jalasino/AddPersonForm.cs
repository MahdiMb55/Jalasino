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
    public partial class AddPersonForm : Form
    {
        private readonly DataContex _context;

        public AddPersonForm()
        {
            InitializeComponent();
            _context = new DataContex();
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            try
            {
                var person = new Models.Person
                {
                    Name = textBoxName.Text.Trim()
                };

                if (string.IsNullOrEmpty(person.Name))
                {
                    MessageBox.Show("Name cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                _context.People.Add(person);
                _context.SaveChanges();
                MessageBox.Show("Person saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearForm()
        {
            textBoxName.Text = string.Empty;
        }
    }
}
