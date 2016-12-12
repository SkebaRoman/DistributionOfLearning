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
    public partial class FormAddTeacher : Form
    {
        ProgramLogicDll.ConnectDb dataBase = new ProgramLogicDll.ConnectDb();
        List<ProgramLogicDll.Subject> subjects = new List<ProgramLogicDll.Subject>();
        public FormAddTeacher()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                listBox2.Items.Add(listBox1.SelectedItem);
                subjects.Add(dataBase.Subjects.Where(subject => subject.Name == listBox1.SelectedItem.ToString()).FirstOrDefault());
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            }
            else
            {
                MessageBox.Show("Choise something for add", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox2.SelectedIndex != -1)
            {
                listBox1.Items.Add(listBox2.SelectedItem);
                subjects.Remove(dataBase.Subjects.Where(subject => subject.Name == listBox2.SelectedItem.ToString()).FirstOrDefault());
                listBox2.Items.RemoveAt(listBox2.SelectedIndex);
            }
            else
            {
                MessageBox.Show("Choise something for remove", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataBase = new ProgramLogicDll.ConnectDb();
            if (textBox1.Text != string.Empty && textBox2.Text != string.Empty && textBox3.Text != string.Empty && textBox4.Text != string.Empty && textBox5.Text != string.Empty && textBox6.Text != string.Empty)
            {
                dataBase.Teachers.Add(new ProgramLogicDll.Teacher
                {
                    FirstName = textBox1.Text,
                    LastName = textBox2.Text,
                    Age = int.Parse(textBox3.Text),
                    PhoneNumber = textBox4.Text,
                    Email = textBox5.Text,
                    Salary = double.Parse(textBox6.Text),
                    Subjects = subjects
                });
                dataBase.SaveChanges(); 
                textBox1.Text = textBox2.Text = textBox3.Text = textBox4.Text = textBox5.Text = textBox6.Text = string.Empty;
                listBox2.Items.Clear(); UpdateSubjects();
                MessageBox.Show("Teacher added", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Enter all fields", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void UpdateSubjects()
        {
            listBox1.Items.Clear(); subjects = new List<ProgramLogicDll.Subject>();
            foreach (var item in dataBase.Subjects)
                listBox1.Items.Add(item.Name);
        }

        private void FormAddTeacher_Load(object sender, EventArgs e)
        {
            UpdateSubjects();
        }
    }
}
