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
        ProgramLogicDll.ConnectDb dataBase = new ProgramLogicDll.ConnectDb();
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
            new FormAddStudent().ShowDialog();
        }

        private void studentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormEditStudent().ShowDialog();
        }

        private void newSubjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormAddSubject().ShowDialog();
        }

        private void subjectsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormEditSubject().ShowDialog();
        }

        private void newTeacherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormAddTeacher().ShowDialog();
        }

        private void teachersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormEditTeacher().ShowDialog();
        }

        private void newSemesterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormAddSemester().ShowDialog();
        }

        private void newSoftwareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormAddSoftware().ShowDialog();
        }

        private void softwaresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormEditSoftware().ShowDialog();
        }

        private void newPCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormAddPC().ShowDialog();
        }

        private void computersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormEditPC().ShowDialog();
        }

        private void editAudiencesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormEditAudience().ShowDialog();
        }

        private void groupsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormEditGroup().ShowDialog();
        }
    }
}
