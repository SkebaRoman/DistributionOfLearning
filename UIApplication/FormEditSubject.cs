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
        List<ProgramLogicDll.Subject> subjects = new List<ProgramLogicDll.Subject>();
        public FormEditSubject()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex != -1&&textBox1.Text!=string.Empty)
            {
                int Id = subjects[comboBox1.SelectedIndex].SubjectId;
                dataBase.Subjects.Where(subject => subject.SubjectId == Id).FirstOrDefault().Name = textBox1.Text;
                dataBase.SaveChanges();
                MessageBox.Show("Save", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void FormEditSubject_Load(object sender, EventArgs e)
        {
            subjects = dataBase.Subjects.ToList();
            foreach (var item in subjects)
                comboBox1.Items.Add(item.Name);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Text = comboBox1.SelectedItem.ToString();
        }
    }
}
