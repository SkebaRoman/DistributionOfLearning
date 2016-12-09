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
    public partial class FormAddStudent : Form
    {
        ProgramLogicDll.ConnectDb dataBase = new ProgramLogicDll.ConnectDb();
        public FormAddStudent()
        {
            InitializeComponent();
            comboBox1.Items.AddRange(new string[] {"Programmer", "Administrator", "Designer" });
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != string.Empty && textBox2.Text != string.Empty && textBox3.Text != string.Empty && textBox4.Text != string.Empty && textBox5.Text != string.Empty && comboBox1.SelectedIndex!=-1)
            {
                dataBase.Students.Add(new ProgramLogicDll.Student
                {
                    FirstName = textBox1.Text,
                    LastName = textBox2.Text,
                    Age = int.Parse(textBox3.Text),
                    PhoneNumber = textBox4.Text,
                    Email = textBox5.Text,
                    Profession = comboBox1.SelectedItem.ToString(),
                    DateOfReceipt = dateTimePicker1.Value,
                    ExpirationDate = dateTimePicker2.Value,
                    Groups = null
                });
                dataBase.SaveChanges();
                textBox1.Text = textBox2.Text = textBox3.Text = textBox4.Text = textBox5.Text = string.Empty;
                MessageBox.Show("Student add", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Enter all fields", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
