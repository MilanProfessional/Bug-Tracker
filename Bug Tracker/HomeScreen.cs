using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bug_Tracker
{
    public partial class HomeScreen : Form
    {
        string[] pictures = { "bug1.jpg", "bug2.jpg", "bug3.jpg", "bug5.png" };
        int i = 0;

       




        

        public HomeScreen()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try { pictureBox1.Image = Image.FromFile("Images/" + pictures[0]); }
            catch (System.IO.FileNotFoundException ex)
            {
                Console.WriteLine(ex);
            }

            timer1.Enabled = false;
            i++;
            if (pictures.Length == i) { i = 0; }
            try
            {
                pictureBox1.Image = Image.FromFile("Images/" + pictures[i]); timer1.Enabled = true;
            }

            catch (System.IO.FileNotFoundException ex)
            {
                Console.WriteLine(ex);
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

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Views.Login().Show();
           
            
        }

        private void loginAsAdminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Views.Admin().Show();
        }

        private void developerInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bug Tracker By:" + Environment.NewLine +
                "Name: Milan Babu Adhikari" + Environment.NewLine +
                "Email: milanadhikari09@live.com" + Environment.NewLine +
                "Contact No.: +9779803818797" + Environment.NewLine +
                "Developed in: Microsoft Visual Studio 2017 Community" + Environment.NewLine,
                "Version 1.0.8 Freeware"
                );
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            i++; if (pictures.Length == i) { i = 0; }
            pictureBox1.Image = Image.FromFile("Images/" + pictures[i]);

        }

      

        private void button2_Click_1(object sender, EventArgs e)
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

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            new Views.Login().Show();
        }
    }
}
