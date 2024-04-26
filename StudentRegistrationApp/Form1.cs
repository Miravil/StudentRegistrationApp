using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace StudentRegistrationApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int days = 0; days <= 31; days++)
            {
                days = comboBox1.Items.Add(days);
            }
            for (int year = DateTime.Now.Year; year >= 1900; year--)
            {
                comboBox3.Items.Add(year);
            }
            string[] months = new string[] { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };

            foreach (string month in months)
            {
                comboBox2.Items.Add(month);
            }
            string[] courses = new string[] { "Bachelor of Science in Computer Science", "Bachelor of Science in Information Technology", "Bachelor of Science in Information System", "Bachelor of Science in Computer Engineering" };

            foreach (string course in courses)
            {
                comboBox4.Items.Add(course);
            }
        }
        public void information(string Firstname, string Lastname, string Program)
        {
            string lastname = textBox2.Text;
            string firstname = textBox1.Text;
            string middlename = textBox3.Text;
            string program = comboBox4.Text;
            string gender = "none";
            string name = firstname + " " + lastname;

            string message = "Student Name : " + firstname + " " + middlename + " " + lastname + " \n" + "Program : " + comboBox4.Text;
            MessageBox.Show(message);
        }
        public void informations(string Studentname, string Program)
        {
            string gender;
            string firsname = textBox1.Text;
            string lastname = textBox2.Text;
            string middlename = textBox3.Text;
            string studentName = "Student Name : " + firsname + " " + lastname;

            if (radioButton1.Checked)
            {
                gender = "Gender : " + radioButton1.Text;
            }
            else if (radioButton2.Checked)
            {
                gender = "Gender : " + radioButton2.Text;
            }
            string DateOfBirth = "Date of birth : " + comboBox1.Text + "/" + comboBox2.Text + "/" + comboBox3.Text;
            string message =

             MessageBox.Show(studentName + "\n" + program);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string lastname = textBox2.Text;
            string firstname = textBox1.Text;
            string middlename = textBox3.Text;
            string studentName = "Student Name : " + firstname + " " + middlename + " " + lastname;
            string gender = "none";
            string DateOfBirth = "Date of birth : " + comboBox1.Text + "/" + comboBox2.Text + "/" + comboBox3.Text;
            string program = "Program : " + comboBox4.Text;

            if (radioButton1.Checked)
            {
                gender = "Gender : " + radioButton1.Text;
            }
            else if (radioButton2.Checked)
            {
                gender = "Gender : " + radioButton2.Text;
            }


            if (lastname != null && firstname != null && middlename != null) && (gender != "none") && (DateOfBirth != null) && (program != null) {
                information(studentName, DateOfBirth, gender, program);
            }
            else if (lastname != null && firstname != null && middlename != null) && (program != null) {
                showinformation(firstname, lastname, program);
            }
            else
            {

            }
        }
        public void information(string name, string date, string Program, string Gender)
        {
            string lastname = textBox2.Text;
            string firstname = textBox1.Text;
            string middlename = textBox3.Text;

            string studentName = "Student Name : " + firstname + " " + middlename + " " + lastname;

            string gender = "none";

            if (radioButton1.Checked)
            {
                gender = "Gender : " + radioButton1.Text;
            }
            else if (radioButton2.Checked)
            {
                gender = "Gender : " + radioButton2.Text;
            }

            string message = "Student Name : " + firstname + " " + middlename + " " + lastname + gender + "\n" + "Date of birth : " + comboBox1.Text + "/" + comboBox2.Text + "/" + comboBox3.Text + "\n" + "Program : " + comboBox4.Text;

            MessageBox.Show(message);
        }
        public void showinformation(string firstname, string lastname, string program)
        {
            string lastname2 = textBox2.Text;
            string firstname2 = textBox1.Text;

            string studentName = "Student Name : " + firstname + " " + middlename + " " + lastname;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            OpenFileDialog image = new OpenFileDialog();
            if (image.ShowDialog() == DialogResult.OK) {
                pictureBox1.Image = Bitmap.FromFile(image.FileName);
            }
        }
    }
}
