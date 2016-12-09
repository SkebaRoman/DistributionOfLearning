using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UIApplication
{
    public partial class FormEditStudent : Form
    {
        ProgramLogicDll.ConnectDb dataBase = new ProgramLogicDll.ConnectDb();
        List<ProgramLogicDll.Student> students = new List<ProgramLogicDll.Student>();
        public FormEditStudent()
        {
            InitializeComponent();
            comboBox2.Items.AddRange(new string[] { "Programmer", "Administrator", "Designer" });
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != string.Empty && textBox2.Text != string.Empty && textBox3.Text != string.Empty && textBox4.Text != string.Empty && textBox5.Text != string.Empty && comboBox2.SelectedIndex!=-1)
            {
                int studentId = students[comboBox1.SelectedIndex].StudentId;
                var student = dataBase.Students.Where(Id=>Id.StudentId == studentId).FirstOrDefault();
                student.FirstName = textBox1.Text;
                student.LastName = textBox2.Text;
                student.Age = int.Parse(textBox3.Text);
                student.PhoneNumber = textBox4.Text;
                student.Email = textBox5.Text;
                student.Profession = comboBox2.SelectedItem.ToString();
                student.DateOfReceipt = dateTimePicker1.Value;
                student.ExpirationDate = dateTimePicker2.Value;
                dataBase.SaveChanges();
                MessageBox.Show("Student edited", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Enter all fields", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex != -1)
            {
                var student = students[comboBox1.SelectedIndex];
                textBox1.Text = student.FirstName;
                textBox2.Text = student.LastName;
                textBox3.Text = student.Age.ToString();
                textBox4.Text = student.PhoneNumber;
                textBox5.Text = student.Email;
                comboBox2.Text = student.Profession;
                dateTimePicker1.Value = student.DateOfReceipt;
                dateTimePicker2.Value = student.ExpirationDate;
            }
        }

        private void FormEditStudent_Load(object sender, EventArgs e)
        {
            students = dataBase.Students.ToList();
            foreach (var item in students)
                comboBox1.Items.Add(item.FirstName + " " + item.LastName);
        }
    }
}
