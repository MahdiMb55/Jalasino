namespace Jalasino
{
    partial class CreateForm
    {
        private System.Windows.Forms.TextBox txtMeetingTitle;
        private System.Windows.Forms.TextBox txtMeetingDate;
        private System.Windows.Forms.TextBox txtMeetingDescription;
        private System.Windows.Forms.Button btnSubmit;

        private void InitializeComponent()
        {
            this.txtMeetingTitle = new System.Windows.Forms.TextBox();
            this.txtMeetingDate = new System.Windows.Forms.TextBox();
            this.txtMeetingDescription = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtMeetingTitle
            // 
            this.txtMeetingTitle.Location = new System.Drawing.Point(50, 50);
            this.txtMeetingTitle.Name = "txtMeetingTitle";
            this.txtMeetingTitle.PlaceholderText = "Enter meeting title";
            this.txtMeetingTitle.Size = new System.Drawing.Size(363, 27);
            this.txtMeetingTitle.TabIndex = 0;
            // 
            // txtMeetingDate
            // 
            this.txtMeetingDate.Location = new System.Drawing.Point(50, 100);
            this.txtMeetingDate.Name = "txtMeetingDate";
            this.txtMeetingDate.PlaceholderText = "Enter meeting date (YYYY-MM-DD)";
            this.txtMeetingDate.Size = new System.Drawing.Size(363, 27);
            this.txtMeetingDate.TabIndex = 1;
            // 
            // txtMeetingDescription
            // 
            this.txtMeetingDescription.Location = new System.Drawing.Point(50, 150);
            this.txtMeetingDescription.Name = "txtMeetingDescription";
            this.txtMeetingDescription.PlaceholderText = "Enter meeting description";
            this.txtMeetingDescription.Size = new System.Drawing.Size(363, 27);
            this.txtMeetingDescription.TabIndex = 2;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(50, 200);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 3;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // CreateForm
            // 
            this.ClientSize = new System.Drawing.Size(600, 400);
            this.ControlBox = false;
            this.Controls.Add(this.txtMeetingTitle);
            this.Controls.Add(this.txtMeetingDate);
            this.Controls.Add(this.txtMeetingDescription);
            this.Controls.Add(this.btnSubmit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CreateForm";
            this.Text = "Create New Meeting";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
