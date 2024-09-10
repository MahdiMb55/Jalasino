using Krypton.Toolkit;

namespace Jalasino
{
    public partial class Form1 : Krypton.Toolkit.KryptonForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //using (DataContex contex = new DataContex())
            //{
            //    contex.Meetings.Add(new Models.Meeting() { People = "mamad - ali hos - mad", Subject = "manabe ensani", Date = DateTime.Now });
            //    contex.SaveChanges();
            //}
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            Views.JalasatMainForm f = new Views.JalasatMainForm();
            f.Show();
            this.Hide();
        }
    }
}