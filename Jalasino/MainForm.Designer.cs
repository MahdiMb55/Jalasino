namespace Jalasino
{
    partial class MainForm
    {
        private System.Windows.Forms.Panel sideMenuPanel;
        private System.Windows.Forms.Button btnMainPage;
        private System.Windows.Forms.Button btnCreateForm;
        private System.Windows.Forms.Button btnListMeetings;
        private System.Windows.Forms.Panel contentPanel;

        private void InitializeComponent()
        {
            this.sideMenuPanel = new System.Windows.Forms.Panel();
            this.btnMainPage = new System.Windows.Forms.Button();
            this.btnCreateForm = new System.Windows.Forms.Button();
            this.btnListMeetings = new System.Windows.Forms.Button();
            this.contentPanel = new System.Windows.Forms.Panel();
            this.sideMenuPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // sideMenuPanel
            // 
            this.sideMenuPanel.BackColor = System.Drawing.Color.LightGray;
            this.sideMenuPanel.Controls.Add(this.btnMainPage);
            this.sideMenuPanel.Controls.Add(this.btnCreateForm);
            this.sideMenuPanel.Controls.Add(this.btnListMeetings);
            this.sideMenuPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.sideMenuPanel.Location = new System.Drawing.Point(799, 0);
            this.sideMenuPanel.Name = "sideMenuPanel";
            this.sideMenuPanel.Size = new System.Drawing.Size(200, 600);
            this.sideMenuPanel.TabIndex = 1;
            // 
            // btnMainPage
            // 
            this.btnMainPage.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMainPage.Location = new System.Drawing.Point(0, 92);
            this.btnMainPage.Name = "btnMainPage";
            this.btnMainPage.Size = new System.Drawing.Size(200, 46);
            this.btnMainPage.TabIndex = 0;
            this.btnMainPage.Text = "لیست مصوبات";
            this.btnMainPage.Click += new System.EventHandler(this.btnMainPage_Click);
            // 
            // btnCreateForm
            // 
            this.btnCreateForm.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCreateForm.Location = new System.Drawing.Point(0, 46);
            this.btnCreateForm.Name = "btnCreateForm";
            this.btnCreateForm.Size = new System.Drawing.Size(200, 46);
            this.btnCreateForm.TabIndex = 1;
            this.btnCreateForm.Text = "لیست جلسات";
            this.btnCreateForm.Click += new System.EventHandler(this.btnCreateForm_Click);
            // 
            // btnListMeetings
            // 
            this.btnListMeetings.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnListMeetings.Location = new System.Drawing.Point(0, 0);
            this.btnListMeetings.Name = "btnListMeetings";
            this.btnListMeetings.Size = new System.Drawing.Size(200, 46);
            this.btnListMeetings.TabIndex = 2;
            this.btnListMeetings.Text = "لیست آخرین مصوبات";
            this.btnListMeetings.Click += new System.EventHandler(this.btnListMeetings_Click);
            // 
            // contentPanel
            // 
            this.contentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contentPanel.Location = new System.Drawing.Point(0, 0);
            this.contentPanel.Name = "contentPanel";
            this.contentPanel.Size = new System.Drawing.Size(799, 600);
            this.contentPanel.TabIndex = 0;
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(999, 600);
            this.Controls.Add(this.contentPanel);
            this.Controls.Add(this.sideMenuPanel);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Meeting Manager";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.sideMenuPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }
    }
}
