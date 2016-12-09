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
        ConnectDb database = new ConnectDb();
        List<Teacher> tec;
        List<Subject> subjects = new List<Subject>();
        public FormEditTeacher()
        {
            InitializeComponent();
        }

        private void FormEditTeacher_Load(object sender, EventArgs e)
        {
            tec = database.Teachers.ToList();
            foreach (var item in tec)
            {
                comboBox1.Items.Add(item.FirstName);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var techer = database.Teachers.Where((x) => x.FirstName == comboBox1.SelectedItem.ToString()).FirstOrDefault();
           
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
            foreach (var item in database.Subjects)
            {
                if(listBox2.Items.Contains(item.Name)==false)
                {
                    listBox1.Items.Add(item.Name);
                }
            }
                    }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != string.Empty && textBox2.Text != string.Empty && textBox3.Text != string.Empty && textBox4.Text != string.Empty && textBox5.Text != string.Empty && textBox6.Text != string.Empty)
            {
                int i = tec[comboBox1.SelectedIndex].TeacherId;
                var teacher = database.Teachers.Where((x) => x.TeacherId == i).FirstOrDefault();
                teacher.FirstName=textBox1.Text ;
                 teacher.LastName= textBox2.Text;
                  teacher.Age=Convert.ToInt32(textBox3.Text);
                 teacher.PhoneNumber= textBox4.Text;
                 teacher.Email= textBox5.Text;
                 teacher.Salary =Convert.ToDouble(textBox6.Text);
                teacher.Subjects = subjects;
                database.SaveChanges();
                MessageBox.Show("Save");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox2.Items.Add(listBox1.SelectedItem);
            subjects.Add(database.Subjects.Where(subject => subject.Name == listBox1.SelectedItems[0].ToString()).FirstOrDefault());
            listBox1.Items.RemoveAt(listBox1.SelectedIndex);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(listBox2.SelectedItems[0]);
            subjects.RemoveAt(listBox2.SelectedIndex);
            listBox2.Items.RemoveAt(listBox2.SelectedIndex);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
