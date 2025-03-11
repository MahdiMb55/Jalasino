namespace Jalasino
{
    partial class AddApprovalForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label labelSubject;
        private System.Windows.Forms.TextBox textBoxSubject;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Label labelActioner;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.Button buttonSave;

        // Form dispose method
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        // Method to initialize form components
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddApprovalForm));
            this.labelSubject = new System.Windows.Forms.Label();
            this.textBoxSubject = new System.Windows.Forms.TextBox();
            this.labelDate = new System.Windows.Forms.Label();
            this.labelActioner = new System.Windows.Forms.Label();
            this.labelStatus = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.btncancel = new System.Windows.Forms.Button();
            this.dateTimePickerDate = new BehComponents.DateTimePickerX();
            this.ComboStatus = new System.Windows.Forms.ComboBox();
            this.chklstboxActioners = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // labelSubject
            // 
            this.labelSubject.AutoSize = true;
            this.labelSubject.Location = new System.Drawing.Point(342, 19);
            this.labelSubject.Name = "labelSubject";
            this.labelSubject.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelSubject.Size = new System.Drawing.Size(61, 20);
            this.labelSubject.TabIndex = 0;
            this.labelSubject.Text = "Subject:";
            // 
            // textBoxSubject
            // 
            this.textBoxSubject.Location = new System.Drawing.Point(69, 16);
            this.textBoxSubject.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxSubject.Name = "textBoxSubject";
            this.textBoxSubject.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBoxSubject.Size = new System.Drawing.Size(250, 27);
            this.textBoxSubject.TabIndex = 0;
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Location = new System.Drawing.Point(342, 69);
            this.labelDate.Name = "labelDate";
            this.labelDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelDate.Size = new System.Drawing.Size(44, 20);
            this.labelDate.TabIndex = 2;
            this.labelDate.Text = "Date:";
            // 
            // labelActioner
            // 
            this.labelActioner.AutoSize = true;
            this.labelActioner.Location = new System.Drawing.Point(342, 124);
            this.labelActioner.Name = "labelActioner";
            this.labelActioner.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelActioner.Size = new System.Drawing.Size(68, 20);
            this.labelActioner.TabIndex = 4;
            this.labelActioner.Text = "Actioner:";
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Location = new System.Drawing.Point(341, 308);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelStatus.Size = new System.Drawing.Size(52, 20);
            this.labelStatus.TabIndex = 6;
            this.labelStatus.Text = "Status:";
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(233, 356);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.buttonSave.Size = new System.Drawing.Size(86, 31);
            this.buttonSave.TabIndex = 4;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // btncancel
            // 
            this.btncancel.Location = new System.Drawing.Point(122, 356);
            this.btncancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btncancel.Name = "btncancel";
            this.btncancel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btncancel.Size = new System.Drawing.Size(86, 31);
            this.btncancel.TabIndex = 5;
            this.btncancel.Text = "انصراف";
            this.btncancel.UseVisualStyleBackColor = true;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // dateTimePickerDate
            // 
            this.dateTimePickerDate.AnchorSize = new System.Drawing.Size(250, 37);
            this.dateTimePickerDate.BackColor = System.Drawing.Color.White;
            this.dateTimePickerDate.CalendarBoldedDayForeColor = System.Drawing.Color.Blue;
            this.dateTimePickerDate.CalendarBorderColor = System.Drawing.Color.CadetBlue;
            this.dateTimePickerDate.CalendarDayRectTickness = 2F;
            this.dateTimePickerDate.CalendarDaysBackColor = System.Drawing.Color.LightGray;
            this.dateTimePickerDate.CalendarDaysFont = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateTimePickerDate.CalendarDaysForeColor = System.Drawing.Color.DodgerBlue;
            this.dateTimePickerDate.CalendarEnglishAnnuallyBoldedDates = new System.DateTime[0];
            this.dateTimePickerDate.CalendarEnglishBoldedDates = new System.DateTime[0];
            this.dateTimePickerDate.CalendarEnglishHolidayDates = new System.DateTime[0];
            this.dateTimePickerDate.CalendarEnglishMonthlyBoldedDates = new System.DateTime[0];
            this.dateTimePickerDate.CalendarHolidayForeColor = System.Drawing.Color.Red;
            this.dateTimePickerDate.CalendarHolidayWeekly = BehComponents.MonthCalendarX.DayOfWeekForHoliday.Friday;
            this.dateTimePickerDate.CalendarLineWeekColor = System.Drawing.Color.Black;
            this.dateTimePickerDate.CalendarPersianAnnuallyBoldedDates = new BehComponents.PersianDateTime[0];
            this.dateTimePickerDate.CalendarPersianBoldedDates = new BehComponents.PersianDateTime[0];
            this.dateTimePickerDate.CalendarPersianHolidayDates = new BehComponents.PersianDateTime[0];
            this.dateTimePickerDate.CalendarPersianMonthlyBoldedDates = new BehComponents.PersianDateTime[0];
            this.dateTimePickerDate.CalendarShowToday = true;
            this.dateTimePickerDate.CalendarShowTodayRect = true;
            this.dateTimePickerDate.CalendarShowToolTips = false;
            this.dateTimePickerDate.CalendarShowTrailing = true;
            this.dateTimePickerDate.CalendarStyle_DaysButton = BehComponents.ButtonX.ButtonStyles.Simple;
            this.dateTimePickerDate.CalendarStyle_GotoTodayButton = BehComponents.ButtonX.ButtonStyles.Green;
            this.dateTimePickerDate.CalendarStyle_MonthButton = BehComponents.ButtonX.ButtonStyles.Blue;
            this.dateTimePickerDate.CalendarStyle_NextMonthButton = BehComponents.ButtonX.ButtonStyles.Green;
            this.dateTimePickerDate.CalendarStyle_PreviousMonthButton = BehComponents.ButtonX.ButtonStyles.Green;
            this.dateTimePickerDate.CalendarStyle_YearButton = BehComponents.ButtonX.ButtonStyles.Blue;
            this.dateTimePickerDate.CalendarTitleBackColor = System.Drawing.Color.Wheat;
            this.dateTimePickerDate.CalendarTitleFont = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateTimePickerDate.CalendarTitleForeColor = System.Drawing.Color.Black;
            this.dateTimePickerDate.CalendarTodayBackColor = System.Drawing.Color.Wheat;
            this.dateTimePickerDate.CalendarTodayFont = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dateTimePickerDate.CalendarTodayForeColor = System.Drawing.Color.Black;
            this.dateTimePickerDate.CalendarTodayRectColor = System.Drawing.Color.Coral;
            this.dateTimePickerDate.CalendarTodayRectTickness = 2F;
            this.dateTimePickerDate.CalendarTrailingForeColor = System.Drawing.Color.DarkGray;
            this.dateTimePickerDate.CalendarType = BehComponents.CalendarTypes.Persian;
            this.dateTimePickerDate.CalendarWeekDaysBackColor = System.Drawing.Color.Wheat;
            this.dateTimePickerDate.CalendarWeekDaysFont = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateTimePickerDate.CalendarWeekDaysForeColor = System.Drawing.Color.OrangeRed;
            this.dateTimePickerDate.CalendarWeekStartsOn = BehComponents.MonthCalendarX.WeekDays.Saturday;
            this.dateTimePickerDate.ClearButtonAlignment = BehComponents.DropDownEmpty.Alignments.Left;
            this.dateTimePickerDate.ClearButtonBackColor = System.Drawing.Color.White;
            this.dateTimePickerDate.ClearButtonForeColor = System.Drawing.SystemColors.ControlText;
            this.dateTimePickerDate.ClearButtonImage = ((System.Drawing.Image)(resources.GetObject("dateTimePickerDate.ClearButtonImage")));
            this.dateTimePickerDate.ClearButtonImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.dateTimePickerDate.ClearButtonImageFixedSize = new System.Drawing.Size(0, 0);
            this.dateTimePickerDate.ClearButtonImageSizeMode = BehComponents.DropDownEmpty.ImageSizeModes.Zoom;
            this.dateTimePickerDate.ClearButtonText = "";
            this.dateTimePickerDate.ClearButtonTextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.dateTimePickerDate.ClearButtonToolTip = "";
            this.dateTimePickerDate.ClearButtonWidth = 17;
            this.dateTimePickerDate.ClearDateTimeWhenDownDeleteKey = true;
            this.dateTimePickerDate.CustomFormat = "";
            this.dateTimePickerDate.DockSide = BehComponents.DropDownEmpty.Alignments.Left;
            this.dateTimePickerDate.DropDownClosedWhenClickOnDays = false;
            this.dateTimePickerDate.DropDownClosedWhenSelectedDateChanged = false;
            this.dateTimePickerDate.Format = BehComponents.DateTimePickerX.FormatDate.Long;
            this.dateTimePickerDate.Format4Binding = "yyyy/MM/dd";
            this.dateTimePickerDate.Location = new System.Drawing.Point(69, 59);
            this.dateTimePickerDate.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.dateTimePickerDate.Name = "dateTimePickerDate";
            this.dateTimePickerDate.RightToLeftLayout = true;
            this.dateTimePickerDate.ShowClearButton = false;
            this.dateTimePickerDate.Size = new System.Drawing.Size(250, 37);
            this.dateTimePickerDate.TabIndex = 1;
            this.dateTimePickerDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.dateTimePickerDate.TextWhenClearButtonClicked = "";
            // 
            // ComboStatus
            // 
            this.ComboStatus.FormattingEnabled = true;
            this.ComboStatus.Location = new System.Drawing.Point(68, 305);
            this.ComboStatus.Name = "ComboStatus";
            this.ComboStatus.Size = new System.Drawing.Size(251, 28);
            this.ComboStatus.TabIndex = 3;
            // 
            // chklstboxActioners
            // 
            this.chklstboxActioners.CheckOnClick = true;
            this.chklstboxActioners.FormattingEnabled = true;
            this.chklstboxActioners.Location = new System.Drawing.Point(27, 124);
            this.chklstboxActioners.Name = "chklstboxActioners";
            this.chklstboxActioners.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chklstboxActioners.Size = new System.Drawing.Size(293, 136);
            this.chklstboxActioners.TabIndex = 2;
            this.chklstboxActioners.Tag = "";
            // 
            // AddApprovalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 422);
            this.Controls.Add(this.chklstboxActioners);
            this.Controls.Add(this.ComboStatus);
            this.Controls.Add(this.dateTimePickerDate);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.labelActioner);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.textBoxSubject);
            this.Controls.Add(this.labelSubject);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "AddApprovalForm";
            this.Text = "Add Approval";
            this.Load += new System.EventHandler(this.AddApprovalForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private Button btncancel;
        private BehComponents.DateTimePickerX dateTimePickerDate;
        private ComboBox ComboStatus;
        private CheckedListBox chklstboxActioners;
    }
}
