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
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void newGroupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAddGroup form = new FormAddGroup();
            form.ShowDialog();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAddAudience form = new FormAddAudience();
            form.ShowDialog();
        }

        private void newStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAddStudent form = new FormAddStudent();
            form.ShowDialog();
        }

        private void newTeacherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormAddTeacher().ShowDialog();
        }

        private void teachersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormEditTeacher().ShowDialog();
        }
    }
}
