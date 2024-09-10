using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Krypton.Toolkit;
using Microsoft.EntityFrameworkCore;

namespace Jalasino.Views
{
    public partial class JalasatMainForm : KryptonForm
    {
        public JalasatMainForm()
        {
            InitializeComponent();
        }
        DataContex db = new DataContex();
        int position = 0;
        private void JalasatMainForm_Load(object sender, EventArgs e)
        {
            db.Meetings
                .OrderBy(b => b.Id)
                .Skip(position)
                .Take(3)
                .Load();
            this.kryptonDataGridView1.DataSource = db.Meetings.Local.ToBindingList();


            KryptonContextMenuItems icol = new KryptonContextMenuItems();
            icol.Items.Add(new KryptonContextMenuItem("Set1",menu_s1));
            icol.Items.Add(new KryptonContextMenuItem("Set2",menu_s2));

            kryptonContextMenu1.Items.Add(icol);
        }

        private void menu_s1(object? sender, EventArgs e)
        {
            MessageBox.Show(selectedId.ToString());
        }

        private void menu_s2(object? sender, EventArgs e)
        {
            MessageBox.Show(selectedId.ToString());
        }

        private void JalasatMainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            db.Dispose();
        }

        private void kryptonDataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < kryptonDataGridView1.Rows.Count-2)
                db.SaveChanges();
        }

        private void kryptonDataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                kryptonContextMenu1.Show(sender,Cursor.Position);
            }
       
        }
        int selectedId;
        private void kryptonDataGridView1_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                try
                {
                    kryptonDataGridView1.CurrentCell = kryptonDataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex];
                    // Can leave these here - doesn't hurt
                    kryptonDataGridView1.Rows[e.RowIndex].Selected = true;
                    kryptonDataGridView1.Focus();

                    selectedId = Convert.ToInt32(kryptonDataGridView1.Rows[e.RowIndex].Cells["Id"].Value);
                }
                catch (Exception)
                {

                }
            }
        }
    }
}
