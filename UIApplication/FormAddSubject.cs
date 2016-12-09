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
            db.Subjects.Add(new Subject() { Name = textBox1.Text});
            db.SaveChanges();
            MessageBox.Show("Save", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            textBox1.Text = string.Empty;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
