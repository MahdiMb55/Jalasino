namespace Jalasino
{
    partial class MainPage
    {
        private System.Windows.Forms.DataGridView dataGridViewMeetings;

        private void InitializeComponent()
        {
            this.dataGridViewMeetings = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMeetings)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewMeetings
            // 
            this.dataGridViewMeetings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMeetings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewMeetings.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewMeetings.Name = "dataGridViewMeetings";
            this.dataGridViewMeetings.RowHeadersWidth = 51;
            this.dataGridViewMeetings.Size = new System.Drawing.Size(240, 150);
            this.dataGridViewMeetings.TabIndex = 0;
            // 
            // MainPage
            // 
            this.ClientSize = new System.Drawing.Size(600, 400);
            this.Controls.Add(this.dataGridViewMeetings);
            this.Name = "MainPage";
            this.Text = "Pending Meetings";
            this.Load += new System.EventHandler(this.MainPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMeetings)).EndInit();
            this.ResumeLayout(false);

        }
    }
}
