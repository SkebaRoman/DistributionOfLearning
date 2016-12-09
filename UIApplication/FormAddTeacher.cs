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
                listBox2.Items.Add(listBox1.SelectedItems[0]);
                subjects.Add(dataBase.Subjects.Where(subject => subject.Name == listBox1.SelectedItems[0].ToString()).FirstOrDefault());
                listBox1.Items.RemoveAt(listBox2.SelectedIndex);
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
                listBox2.Items.RemoveAt(listBox2.SelectedIndex);
                subjects.RemoveAt(listBox2.SelectedIndex);
                listBox1.Items.Add(listBox2.SelectedItems[0]);
            }
            else
            {
                MessageBox.Show("Choise something for remove", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
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
            }
            else
            {
                MessageBox.Show("Enter all fields", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void FormAddTeacher_Load(object sender, EventArgs e)
        {
            foreach (var item in dataBase.Subjects)
                listBox1.Items.Add(item.Name);
        }
    }
}
