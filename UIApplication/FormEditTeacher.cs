using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProgramLogicDll;
namespace UIApplication
{
    public partial class FormEditTeacher : Form
    {
        ConnectDb dataBase = new ConnectDb();
        List<Subject> subjects = new List<Subject>();
        List<Teacher> teachers = new List<Teacher>();
        public FormEditTeacher()
        {
            InitializeComponent();
        }

        private void UpdateTeachers()
        {
            subjects = new List<Subject>();
            teachers = new List<Teacher>();
            teachers = dataBase.Teachers.ToList();
            comboBox1.Items.Clear(); comboBox1.Text = string.Empty;
            foreach (var item in teachers)
                comboBox1.Items.Add(item.FirstName + " " + item.LastName);
        }

        private void FormEditTeacher_Load(object sender, EventArgs e)
        {
            UpdateTeachers();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            subjects = new List<Subject>();
            listBox1.Items.Clear(); listBox2.Items.Clear();
            int id = teachers[comboBox1.SelectedIndex].TeacherId;
            var techer = dataBase.Teachers.Where(x => x.TeacherId == id).FirstOrDefault();

            textBox1.Text = techer.FirstName;
            textBox2.Text = techer.LastName;
            textBox3.Text = techer.Age.ToString();
            textBox4.Text = techer.PhoneNumber;
            textBox5.Text = techer.Email;
            textBox6.Text = techer.Salary.ToString();
            
            foreach (var item in techer.Subjects)
            {
                listBox2.Items.Add(item.Name);
                subjects.Add(item);
            }

            foreach (var item in dataBase.Subjects)
            {
                bool check = true;
                foreach (var item1 in listBox2.Items)
                {
                    if (item1.ToString()==item.Name)
                    {
                        check = false;
                        break;
                    }
                }
                if (check == true)
                    listBox1.Items.Add(item.Name);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != string.Empty && textBox2.Text != string.Empty && textBox3.Text != string.Empty && textBox4.Text != string.Empty && textBox5.Text != string.Empty && textBox6.Text != string.Empty)
            {
                int i = teachers[comboBox1.SelectedIndex].TeacherId;
                var teacher = dataBase.Teachers.Where((x) => x.TeacherId == i).FirstOrDefault();
                teacher.FirstName = textBox1.Text;
                teacher.LastName = textBox2.Text;
                teacher.Age = Convert.ToInt32(textBox3.Text);
                teacher.PhoneNumber = textBox4.Text;
                teacher.Email = textBox5.Text;
                teacher.Salary = Convert.ToDouble(textBox6.Text);
                teacher.Subjects = subjects;
                dataBase.SaveChanges(); listBox1.Items.Clear(); listBox2.Items.Clear(); UpdateTeachers();
                textBox1.Text = textBox2.Text = textBox3.Text = textBox4.Text = textBox5.Text = textBox6.Text = string.Empty;
                MessageBox.Show("Teacher edited", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Enter all fields", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
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
                MessageBox.Show("Choise subject", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                MessageBox.Show("Choise subject", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
