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
    public partial class FormAddSubject : Form
    {
        ConnectDb db = new ConnectDb();
        public FormAddSubject()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Метод для добавлення предмету
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click_1(object sender, EventArgs e)
        {
            if (textBox1.Text != string.Empty && comboBox1.SelectedIndex!=-1)
            {
                if (db.Subjects.Where(name => name.Name == textBox1.Text).FirstOrDefault() == null)
                {
                    int semestr = int.Parse(comboBox1.SelectedItem.ToString());
                    db.Subjects.Add(new Subject() { Name = textBox1.Text, Semesters=db.Semesters.Where(sem=>sem.SemesterNumber==semestr).FirstOrDefault() });
                    db.SaveChanges();
                    textBox1.Text = string.Empty; comboBox1.Text = string.Empty;  comboBox1.SelectedIndex = -1; 
                    MessageBox.Show("Subject added", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("This subject already exists", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Enter subject or choise semester", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// Закриття форми
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormAddSubject_Load(object sender, EventArgs e)
        {
            foreach (var item in db.Semesters)
                comboBox1.Items.Add(item.SemesterNumber);
        }
    }
}
