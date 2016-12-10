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

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (textBox1.Text != string.Empty)
            {
                if (db.Subjects.Where(name => name.Name == textBox1.Text).FirstOrDefault() == null)
                {
                    db.Subjects.Add(new Subject() { Name = textBox1.Text });
                    db.SaveChanges();
                    textBox1.Text = string.Empty;
                    MessageBox.Show("Subject added", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("This subject already exists", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Enter subject", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
