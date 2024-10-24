namespace Jalasino
{
    partial class MeetingsListPage
    {
        private System.Windows.Forms.DataGridView dataGridViewAllMeetings;

        private void InitializeComponent()
        {
            this.dataGridViewAllMeetings = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAllMeetings)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewAllMeetings
            // 
            this.dataGridViewAllMeetings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAllMeetings.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridViewAllMeetings.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewAllMeetings.Name = "dataGridViewAllMeetings";
            this.dataGridViewAllMeetings.RowHeadersWidth = 51;
            this.dataGridViewAllMeetings.Size = new System.Drawing.Size(600, 388);
            this.dataGridViewAllMeetings.TabIndex = 0;
            // 
            // MeetingsListPage
            // 
            this.ClientSize = new System.Drawing.Size(600, 400);
            this.Controls.Add(this.dataGridViewAllMeetings);
            this.Name = "MeetingsListPage";
            this.Text = "All Meetings";
            this.Load += new System.EventHandler(this.MeetingsListPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAllMeetings)).EndInit();
            this.ResumeLayout(false);

        }
    }
}
