namespace Jalasino
{
    partial class ApprovalsListPage
    {
        private System.Windows.Forms.DataGridView dataGridViewAllApprovals;

        private void InitializeComponent()
        {
            this.dataGridViewAllApprovals = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAllApprovals)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewAllApprovals
            // 
            this.dataGridViewAllApprovals.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAllApprovals.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridViewAllApprovals.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewAllApprovals.Name = "dataGridViewAllApprovals";
            this.dataGridViewAllApprovals.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridViewAllApprovals.RowHeadersWidth = 51;
            this.dataGridViewAllApprovals.Size = new System.Drawing.Size(583, 388);
            this.dataGridViewAllApprovals.TabIndex = 0;
            // 
            // ApprovalsListPage
            // 
            this.ClientSize = new System.Drawing.Size(583, 418);
            this.Controls.Add(this.dataGridViewAllApprovals);
            this.Name = "ApprovalsListPage";
            this.Text = "All Meetings";
            this.Load += new System.EventHandler(this.MeetingsListPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAllApprovals)).EndInit();
            this.ResumeLayout(false);

        }
    }
}
