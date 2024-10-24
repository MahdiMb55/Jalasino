namespace Jalasino
{
    partial class CreateForm
    {
        private System.Windows.Forms.TextBox txtMeetingTitle;
        private System.Windows.Forms.TextBox txtMeetingDescription;
        private System.Windows.Forms.Button btnSubmit;

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateForm));
            this.txtMeetingTitle = new System.Windows.Forms.TextBox();
            this.txtMeetingDescription = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.dtpickerMeetingDate = new BehComponents.DateTimePickerX();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.chkboxlstPeople = new System.Windows.Forms.CheckedListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtMeetingTitle
            // 
            this.txtMeetingTitle.Location = new System.Drawing.Point(50, 20);
            this.txtMeetingTitle.Name = "txtMeetingTitle";
            this.txtMeetingTitle.PlaceholderText = "عنوان جلسه را وارد کنید";
            this.txtMeetingTitle.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtMeetingTitle.Size = new System.Drawing.Size(363, 27);
            this.txtMeetingTitle.TabIndex = 0;
            // 
            // txtMeetingDescription
            // 
            this.txtMeetingDescription.Location = new System.Drawing.Point(50, 306);
            this.txtMeetingDescription.Name = "txtMeetingDescription";
            this.txtMeetingDescription.PlaceholderText = "توضیحات جلسه را وارد کنید";
            this.txtMeetingDescription.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtMeetingDescription.Size = new System.Drawing.Size(363, 27);
            this.txtMeetingDescription.TabIndex = 2;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(50, 348);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnSubmit.Size = new System.Drawing.Size(75, 40);
            this.btnSubmit.TabIndex = 3;
            this.btnSubmit.Text = "ثبت";
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // dtpickerMeetingDate
            // 
            this.dtpickerMeetingDate.AnchorSize = new System.Drawing.Size(250, 41);
            this.dtpickerMeetingDate.BackColor = System.Drawing.Color.White;
            this.dtpickerMeetingDate.CalendarBoldedDayForeColor = System.Drawing.Color.Blue;
            this.dtpickerMeetingDate.CalendarBorderColor = System.Drawing.Color.CadetBlue;
            this.dtpickerMeetingDate.CalendarDayRectTickness = 2F;
            this.dtpickerMeetingDate.CalendarDaysBackColor = System.Drawing.Color.LightGray;
            this.dtpickerMeetingDate.CalendarDaysFont = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpickerMeetingDate.CalendarDaysForeColor = System.Drawing.Color.DodgerBlue;
            this.dtpickerMeetingDate.CalendarEnglishAnnuallyBoldedDates = new System.DateTime[0];
            this.dtpickerMeetingDate.CalendarEnglishBoldedDates = new System.DateTime[0];
            this.dtpickerMeetingDate.CalendarEnglishHolidayDates = new System.DateTime[0];
            this.dtpickerMeetingDate.CalendarEnglishMonthlyBoldedDates = new System.DateTime[0];
            this.dtpickerMeetingDate.CalendarHolidayForeColor = System.Drawing.Color.Red;
            this.dtpickerMeetingDate.CalendarHolidayWeekly = BehComponents.MonthCalendarX.DayOfWeekForHoliday.Friday;
            this.dtpickerMeetingDate.CalendarLineWeekColor = System.Drawing.Color.Black;
            this.dtpickerMeetingDate.CalendarPersianAnnuallyBoldedDates = new BehComponents.PersianDateTime[0];
            this.dtpickerMeetingDate.CalendarPersianBoldedDates = new BehComponents.PersianDateTime[0];
            this.dtpickerMeetingDate.CalendarPersianHolidayDates = new BehComponents.PersianDateTime[0];
            this.dtpickerMeetingDate.CalendarPersianMonthlyBoldedDates = new BehComponents.PersianDateTime[0];
            this.dtpickerMeetingDate.CalendarShowToday = true;
            this.dtpickerMeetingDate.CalendarShowTodayRect = true;
            this.dtpickerMeetingDate.CalendarShowToolTips = false;
            this.dtpickerMeetingDate.CalendarShowTrailing = true;
            this.dtpickerMeetingDate.CalendarStyle_DaysButton = BehComponents.ButtonX.ButtonStyles.Simple;
            this.dtpickerMeetingDate.CalendarStyle_GotoTodayButton = BehComponents.ButtonX.ButtonStyles.Green;
            this.dtpickerMeetingDate.CalendarStyle_MonthButton = BehComponents.ButtonX.ButtonStyles.Blue;
            this.dtpickerMeetingDate.CalendarStyle_NextMonthButton = BehComponents.ButtonX.ButtonStyles.Green;
            this.dtpickerMeetingDate.CalendarStyle_PreviousMonthButton = BehComponents.ButtonX.ButtonStyles.Green;
            this.dtpickerMeetingDate.CalendarStyle_YearButton = BehComponents.ButtonX.ButtonStyles.Blue;
            this.dtpickerMeetingDate.CalendarTitleBackColor = System.Drawing.Color.Wheat;
            this.dtpickerMeetingDate.CalendarTitleFont = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpickerMeetingDate.CalendarTitleForeColor = System.Drawing.Color.Black;
            this.dtpickerMeetingDate.CalendarTodayBackColor = System.Drawing.Color.Wheat;
            this.dtpickerMeetingDate.CalendarTodayFont = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dtpickerMeetingDate.CalendarTodayForeColor = System.Drawing.Color.Black;
            this.dtpickerMeetingDate.CalendarTodayRectColor = System.Drawing.Color.Coral;
            this.dtpickerMeetingDate.CalendarTodayRectTickness = 2F;
            this.dtpickerMeetingDate.CalendarTrailingForeColor = System.Drawing.Color.DarkGray;
            this.dtpickerMeetingDate.CalendarType = BehComponents.CalendarTypes.Persian;
            this.dtpickerMeetingDate.CalendarWeekDaysBackColor = System.Drawing.Color.Wheat;
            this.dtpickerMeetingDate.CalendarWeekDaysFont = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpickerMeetingDate.CalendarWeekDaysForeColor = System.Drawing.Color.OrangeRed;
            this.dtpickerMeetingDate.CalendarWeekStartsOn = BehComponents.MonthCalendarX.WeekDays.Saturday;
            this.dtpickerMeetingDate.ClearButtonAlignment = BehComponents.DropDownEmpty.Alignments.Left;
            this.dtpickerMeetingDate.ClearButtonBackColor = System.Drawing.Color.White;
            this.dtpickerMeetingDate.ClearButtonForeColor = System.Drawing.SystemColors.ControlText;
            this.dtpickerMeetingDate.ClearButtonImage = ((System.Drawing.Image)(resources.GetObject("dtpickerMeetingDate.ClearButtonImage")));
            this.dtpickerMeetingDate.ClearButtonImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.dtpickerMeetingDate.ClearButtonImageFixedSize = new System.Drawing.Size(0, 0);
            this.dtpickerMeetingDate.ClearButtonImageSizeMode = BehComponents.DropDownEmpty.ImageSizeModes.Zoom;
            this.dtpickerMeetingDate.ClearButtonText = "";
            this.dtpickerMeetingDate.ClearButtonTextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.dtpickerMeetingDate.ClearButtonToolTip = "";
            this.dtpickerMeetingDate.ClearButtonWidth = 17;
            this.dtpickerMeetingDate.ClearDateTimeWhenDownDeleteKey = true;
            this.dtpickerMeetingDate.CustomFormat = "";
            this.dtpickerMeetingDate.DockSide = BehComponents.DropDownEmpty.Alignments.Left;
            this.dtpickerMeetingDate.DropDownClosedWhenClickOnDays = false;
            this.dtpickerMeetingDate.DropDownClosedWhenSelectedDateChanged = false;
            this.dtpickerMeetingDate.Format = BehComponents.DateTimePickerX.FormatDate.Long;
            this.dtpickerMeetingDate.Format4Binding = "yyyy/MM/dd";
            this.dtpickerMeetingDate.Location = new System.Drawing.Point(163, 68);
            this.dtpickerMeetingDate.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.dtpickerMeetingDate.Name = "dtpickerMeetingDate";
            this.dtpickerMeetingDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dtpickerMeetingDate.RightToLeftLayout = true;
            this.dtpickerMeetingDate.ShowClearButton = false;
            this.dtpickerMeetingDate.Size = new System.Drawing.Size(250, 41);
            this.dtpickerMeetingDate.TabIndex = 4;
            this.dtpickerMeetingDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.dtpickerMeetingDate.TextWhenClearButtonClicked = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(483, 23);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(87, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "عنوان جلسه:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(489, 78);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(81, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "تاریخ جلسه:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(494, 309);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(76, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "توضیحات :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // chkboxlstPeople
            // 
            this.chkboxlstPeople.FormattingEnabled = true;
            this.chkboxlstPeople.Location = new System.Drawing.Point(50, 132);
            this.chkboxlstPeople.Name = "chkboxlstPeople";
            this.chkboxlstPeople.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkboxlstPeople.Size = new System.Drawing.Size(363, 158);
            this.chkboxlstPeople.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(435, 132);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(135, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "افراد حاضر در جلسه:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CreateForm
            // 
            this.ClientSize = new System.Drawing.Size(600, 400);
            this.Controls.Add(this.chkboxlstPeople);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpickerMeetingDate);
            this.Controls.Add(this.txtMeetingTitle);
            this.Controls.Add(this.txtMeetingDescription);
            this.Controls.Add(this.btnSubmit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "CreateForm";
            this.Text = "ثبت جلسه جدید";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private BehComponents.DateTimePickerX dtpickerMeetingDate;
        private Label label1;
        private Label label2;
        private Label label3;
        private CheckedListBox chkboxlstPeople;
        private Label label4;
    }
}
