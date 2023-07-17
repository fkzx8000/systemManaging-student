using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TDD_work.Exeptions;
using TDD_work.Logic;

namespace TDD_work
{
    public partial class Home : Form
    {

        private bool Showflag;
        private static UserInfo On_Off_Info;

        private static bool ranCrit = false;
        public Home()
        {
            InitializeComponent();
            Showflag = false;
        }
        public Home(bool flag, UserInfo obj)
        {
            obj.Hide();
            InitializeComponent();
            Showflag = flag;
        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Random_cleck_Click(object sender, EventArgs e)
        {
            if (!ranCrit)
            {
                ControlCSV.AdduserList(RandomUserGenerator.generateRandomUsers());
                ranCrit = true;
                if (Showflag)
                {
                    On_Off_Info.Close();
                    Showflag = false;
                }
            }
        }

        private void Data_base_but_Click(object sender, EventArgs e)
        {
            this.Hide();
            if (!Showflag)
            {
                On_Off_Info = new UserInfo(Showflag);
                On_Off_Info.ShowDialog();
            }
            else { On_Off_Info.Show(); }
            this.Close();
        }

        private void Update_bu_Click(object sender, EventArgs e)
        {
            try
            {
                // Test Phone number
                ArgumentTest.testPhone(PhoneNum_TextBox.Text);

                // Test Email
                ArgumentTest.testEmail(Email_TextBox.Text);

                // Test ID
                ArgumentTest.testID(ID_TextBox.Text);

                // Test first name & last name
                ArgumentTest.testName(first_name_TextBox.Text);
                ArgumentTest.testName(lestname_TextBox.Text);

                // Test Grades
                ArgumentTest.testGrade(Physics_textBox.Text, "Physics");
                ArgumentTest.testGrade(Khadu_textBox.Text, "Calculus");
                ArgumentTest.testGrade(Computer_Science_textBox.Text, "ComputerScience");
                ArgumentTest.testGrade(textBox4.Text, "History");
                ArgumentTest.testGrade(industry_management_textBox.Text, "IndustrialEngineering");

                ControlCSV.AddUser(first_name_TextBox.Text, lestname_TextBox.Text, ID_TextBox.Text, Email_TextBox.Text,
                    PhoneNum_TextBox.Text, Physics_textBox.Text, Khadu_textBox.Text,
                    Computer_Science_textBox.Text, textBox4.Text, industry_management_textBox.Text);

                // Clear the text Boxes
                first_name_TextBox.Clear(); lestname_TextBox.Clear(); ID_TextBox.Clear(); 
                Email_TextBox.Clear(); PhoneNum_TextBox.Clear(); Physics_textBox.Clear(); Khadu_textBox.Clear(); Computer_Science_textBox.Clear();
                textBox4.Clear(); industry_management_textBox.Clear();


                ID_TextBox.Text = "";
                // Display success message
                MessageBox.Show("Student has successfully added", "success");

            }
            catch (ArgumentEmptyException message)
            {
                MessageBox.Show("The text box of " + message.Message + " is empty", "Error");
            }
            catch (ArgumentAlphaException)
            {
                MessageBox.Show("First name or last name mast use only alphabet", "Error");
            }
            catch (EmailException)
            {
                MessageBox.Show("Email mast be in the form: word@word.__ or word@word.___", "Error");
            }
            catch (PhoneNumberException)
            {
                MessageBox.Show("Phone mast be in the form: ...-....... or .......... and made of digits", "Error");
            }
            catch (ArgumentOutOfRangeException message)
            {
                MessageBox.Show(message.ParamName, "Error");
            }
            catch (NumericalExpression message)
            {
                MessageBox.Show(message.Message + " can only be numerical", "Error");
            }


            // Clear the text Boxes
            foreach (Control c in this.Controls)
            {
                if (c is TextBox)
                {
                    ((TextBox)c).Clear();
                }
            }

            if (Showflag)
            {
                On_Off_Info.Close();
                Showflag = false;
            }


        }

        private void ID_TextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void first_name_TextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void lestname_TextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Email_TextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void PhoneNum_TextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Khadu_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Physics_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Computer_Science_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void industry_management_textBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
