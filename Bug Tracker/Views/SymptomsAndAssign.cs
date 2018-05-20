using Bug_Tracker.DAO;
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
    public partial class SymptomsAndAssign : Form
    {
        //add button 1
        //update butto 2
        int id = 0;
        private int programmerId = 0;
        public SymptomsAndAssign()
        {
            InitializeComponent();
            //button4.Hide();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            BugInformationDAO bugInformationDAO = new BugInformationDAO();
            BugInformation bugInformation = new BugInformation
            {
                Cause = textBox2.Text,
                Symtons = textBox1.Text,
                BugId = Program.bugId
                
            };


            if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("You must add symptons and cause");
            }
            else
            {
                try
                {
                    bugInformationDAO.Insert(bugInformation);
                    MessageBox.Show("Added");
                    button1.Hide();
                    button2.Show();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        private void SymptonsAndAssign_Load(object sender, EventArgs e)
        {
            

        }

        //private void assignedUser()
        //{
        //    listBox1.Items.Clear();
        //    AssignDAO assignDAO = new AssignDAO();
        //    List<string> assignList = assignDAO.GetAllAssignedUsersByBugId(Program.bugId);
        //    foreach (var a in assignList)
        //    {
        //        listBox1.Items.Add(a);
        //    }
        //}

        private void button2_Click(object sender, EventArgs e)
        {
            BugInformationDAO bugInformationDAO = new BugInformationDAO();
            BugInformation bugInformation = new BugInformation
            {
                Cause = textBox2.Text,
                Symtons = textBox1.Text,
                BugId = Program.bugId
            };


            if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("You must add symptons and cause");
            }
            else
            {
                try
                {
                    bugInformationDAO.Update(bugInformation);
                    MessageBox.Show("Updated");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //button4.Show();
            AssignDAO bugInformationDAO = new AssignDAO();
            string value = comboBox1.SelectedItem.ToString();
            string[] s = value.Split(',');

            id = Convert.ToInt32(s[0]);

            //Assign assign = new Assign
            //{
            //    AssignBy = Program.userId,
            //    AssignTo = id,
            //    Description = textBox3.Text.ToString()
            //};

            //try
            //{
            //    bugInformationDAO.Insert(assign);
            //    MessageBox.Show("Task assigned");
            //} catch(Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}

        }

        private void button3_Click(object sender, EventArgs e)
        {
           // assignedUser();
            Assign assign = new Assign
            {
                AssignBy = Login.userId,
                AssignTo = id,
                Description = textBox3.Text,
                BugId = Program.bugId
            };

            AssignDAO assignDAO = new AssignDAO();

            try
            {
                assignDAO.Insert(assign);
                MessageBox.Show("Task assigned");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            AssignDAO assignDAO = new AssignDAO();

            try
            {
                bool res = assignDAO.RemoveAssignedUser(Program.bugId, id);

                if (res)
                {
                   // assignedUser();
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }


        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            //assignedUser();
            Assign assign = new Assign
            {
                AssignBy = Login.userId,
                AssignTo = id,
                Description = textBox3.Text,
                BugId = Program.bugId
            };

            AssignDAO assignDAO = new AssignDAO();

            try
            {
                assignDAO.Insert(assign);
                MessageBox.Show("Task assigned");
                this.Hide();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            AssignDAO assignDAO = new AssignDAO();

            try
            {
                bool res = assignDAO.RemoveAssignedUser(Program.bugId, id);

                if (res)
                {
                   // assignedUser();
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            BugInformationDAO bugInformationDAO = new BugInformationDAO();
            BugInformation bugInformation = new BugInformation
            {
                Cause = textBox2.Text,
                Symtons = textBox1.Text,
                BugId = Program.bugId
            };


            if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("You must add symptons and cause");
            }
            else
            {
                try
                {
                    bugInformationDAO.Update(bugInformation);
                    MessageBox.Show("Updated");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

           
 
            BugInformationDAO bugInformationDAO = new BugInformationDAO();
            BugInformation bugInformation = new BugInformation
            {
                Cause = textBox2.Text,
                Symtons = textBox1.Text,
                BugId = Program.bugId
            };


            if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("You must add symptons and cause");
            }
            else
            {
                try
                {
                    bugInformationDAO.Insert(bugInformation);
                    MessageBox.Show("Added");
                    button1.Hide();
                    button2.Show();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            AssignDAO bugInformationDAO = new AssignDAO();
            string value = comboBox1.SelectedItem.ToString();
            string[] s = value.Split(',');

            id = Convert.ToInt32(s[0]);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void SymptomsAndAssign_Load(object sender, EventArgs e)
        {

            if (!Program.isTester)
            {
                textBox1.Enabled = false;
                textBox2.Enabled = false;
                button1.Hide();
                button1.Enabled = false;
                button2.Hide();
                button2.Hide();
                button2.Enabled = false;
                button3.Hide();
                label3.Text= "Message";
                comboBox1.Hide();
               // textBox3.Hide();
                AssignDAO bugAssignMessageDao = new AssignDAO();
                Assign bugAssignMessage = bugAssignMessageDao.GetById(Program.bugId);
                textBox3.Text = bugAssignMessage.Description;
                textBox3.Enabled = false;


            }
          

            BugInformationDAO bugInformationDAO = new BugInformationDAO();
            BugInformation bugInformation = bugInformationDAO.GetById(Program.bugId);

            if (bugInformation != null)
            {
                button1.Hide();
                button2.Show();
                textBox1.Text = bugInformation.Symtons;                textBox2.Text = bugInformation.Cause;
            }
            else
            {
                button1.Show();
                button2.Show();
            }

            ProgrammerDAO programmerDAO = new ProgrammerDAO();
            List<Programmer> list = programmerDAO.GetAll();


            foreach (var l in list)
            {
                comboBox1.Items.Add(l.ProgrammerId + "," + l.FullName);
                //comboBox1.DisplayMember = l.FullName;
                //comboBox1.ValueMember = l.ProgrammerId.ToString();
            }

           // assignedUser();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }
    }
}
