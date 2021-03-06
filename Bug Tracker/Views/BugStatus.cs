﻿using Bug_Tracker.DAO;
using Bug_Tracker.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bug_Tracker.Views
{
    public partial class BugStatus : Form
    {
        public BugStatus()
        {
            InitializeComponent();
        }

        private void BugStatus_Load(object sender, EventArgs e)
        {
            FixerDAO fixerDAO = new FixerDAO();
            List<Fixer> list = null;
            try
            {
                list = fixerDAO.GetBugFixers();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Bug Id");
            dataTable.Columns.Add("Fixed Date");
            dataTable.Columns.Add("Full Name");

            DataRow dataRow = null;
            foreach (var l in list)
            {
                dataRow = dataTable.NewRow();
                dataRow["Bug Id"] = l.BugId;
                dataRow["Fixed Date"] = l.FixedDate;
                dataRow["Full Name"] = l.programmer.FullName;
                try
                {
                    dataTable.Rows.Add(dataRow);
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex);
                }
            }

            foreach (DataRow dt in dataTable.Rows)
            {
                try
                {
                    int num = dataGridView1.Rows.Add();
                    dataGridView1.Rows[num].Cells[0].Value = dt["Bug Id"].ToString();
                    dataGridView1.Rows[num].Cells[1].Value = dt["Fixed Date"].ToString();
                    dataGridView1.Rows[num].Cells[2].Value = dt["Full Name"].ToString();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Do You want to quit ?", "Quit", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
            else if (dialogResult == DialogResult.No)
            {

            }
        }

        private void adminDashboardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new AdminDashboard().Show();
        }
    }
}
