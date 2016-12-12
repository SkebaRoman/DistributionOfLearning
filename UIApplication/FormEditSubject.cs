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
    public partial class FormEditSubject : Form
    {
        ProgramLogicDll.ConnectDb dataBase = new ProgramLogicDll.ConnectDb();
        public FormEditSubject()
        {
            InitializeComponent();
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

        /// <summary>
        /// Обновлення ComboBox предметів
        /// </summary>
        private void UpdateSubjects()
        {
            comboBox1.Items.Clear(); comboBox1.Text = string.Empty;
            foreach (var item in dataBase.Subjects)
                comboBox1.Items.Add(item.Name);
        }

        /// <summary>
        /// Збереження відредактованого предмету
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text!=string.Empty && comboBox1.SelectedIndex!=-1)
            {
                if (dataBase.Subjects.Where(subject => subject.Name == textBox1.Text).FirstOrDefault() == null)
                {
                    dataBase.Subjects.Where(subject => subject.Name == comboBox1.SelectedItem.ToString()).FirstOrDefault().Name = textBox1.Text;
                    dataBase.SaveChanges();
                    textBox1.Text = string.Empty;
                    UpdateSubjects();
                    MessageBox.Show("Subject edited", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("This subject already exists", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Enter or choise subject", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void FormEditSubject_Load(object sender, EventArgs e)
        {
            UpdateSubjects();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Text = comboBox1.SelectedItem.ToString();
        }
    }
}
