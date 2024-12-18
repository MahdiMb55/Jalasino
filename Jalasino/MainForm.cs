﻿using Jalasino;
using System;
using System.Windows.Forms;

namespace Jalasino
{
    public partial class MainForm : Form
    {
        private readonly DataContex _context;
        private MainPage mainPage;
        private CreateForm createForm;
        private AllMeetingList allMeetingList;
        private ApprovalsListPage approvalslistpage;
        public MainForm()
        {
            InitializeComponent();
            _context = new DataContex();
            mainPage = new MainPage();
            approvalslistpage = new ApprovalsListPage();  
            createForm = new CreateForm();
            allMeetingList = new AllMeetingList();
            LoadPendingMeetings();
        }

        private void LoadPendingMeetings()
        {
            // Load pending meetings (before today) from the database
            var meetings = _context.Meetings
                                   .Where(m => m.Date < DateTime.Today)
                                   .ToList();

            // Bind data to DataGridView
            mainPage.LoadPendingMeetings(meetings);
        }

        // Method to handle navigation to pages
        private void btnMainPage_Click(object sender, EventArgs e)
        {
            ShowPage(mainPage);
        }

        private void btnCreateForm_Click(object sender, EventArgs e)
        {
            ShowPage(allMeetingList);
        }

        private void btnListMeetings_Click(object sender, EventArgs e)
        {
            ShowPage(approvalslistpage);
        }

        // Method to dynamically load and show pages in contentPanel
        private void ShowPage(Form page)
        {
            contentPanel.Controls.Clear(); // Clear previous controls
            page.TopLevel = false; // Make form a control
            page.Dock = DockStyle.Fill; // Make it fill the panel
            contentPanel.Controls.Add(page); // Add the form to the panel
            page.FormBorderStyle = FormBorderStyle.None;
            page.ControlBox=false;
            page.Show(); // Show the form
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            ShowPage(approvalslistpage);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ShowPage(createForm);
        }
    }
}
