﻿using Bug_Tracker.DAO;
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
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
            txtPassword.PasswordChar = '*';  //this will hide password by *
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            new AdminRegister().Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password)) // validation
            {
                MessageBox.Show("Username and password cann't be null");
            }
            else
            {
                AdminDAO adminDAO = new AdminDAO();
                int id = adminDAO.IsLogin(username, password);

                if (id > 0)
                {
                    Program.adminId = id;
                    new AdminDashboard().Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Either username or password is wrong");
                }
            }
        }

        private void Admin_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)  // back to home
        {
            this.Hide();
            new HomeScreen().Show();
        }
    }
}
