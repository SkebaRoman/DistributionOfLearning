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

        /// <summary>
        /// Виклик форми для добавлення групи
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void newGroupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormAddGroup().ShowDialog();
        }

        /// <summary>
        /// Виклик форми для добавлення аудиторії
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormAddAudience().ShowDialog();
        }

        /// <summary>
        /// Виклик форми для добавлення студента
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void newStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormAddStudent().ShowDialog();
        }

        /// <summary>
        /// Виклик форми для редагування студента
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void studentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormEditStudent().ShowDialog();
        }

        /// <summary>
        /// Виклик форми для добавлення предмета
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void newSubjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormAddSubject().ShowDialog();
        }

        /// <summary>
        /// Виклик форми для редагування предмета
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void subjectsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormEditSubject().ShowDialog();
        }

        /// <summary>
        /// Виклик форми для добавлення вчителя
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void newTeacherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormAddTeacher().ShowDialog();
        }

        /// <summary>
        /// Виклик форми для редагування вчителя
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void teachersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormEditTeacher().ShowDialog();
        }

        /// <summary>
        /// Виклик форми для добавлення семестру
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void newSemesterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormAddSemester().ShowDialog();
        }

        /// <summary>
        /// Виклик форми для добавлення ПЗ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void newSoftwareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormAddSoftware().ShowDialog();
        }

        /// <summary>
        /// Виклик форми для редагування ПЗ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void softwaresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormEditSoftware().ShowDialog();
        }

        /// <summary>
        /// Виклик форми для добавлення компютера
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void newPCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormAddPC().ShowDialog();
        }

        /// <summary>
        /// Виклик форми для редагування компютера
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void computersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormEditPC().ShowDialog();
        }

        /// <summary>
        /// Виклик форми для редагування аудиторії
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void editAudiencesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormEditAudience().ShowDialog();
        }

        /// <summary>
        /// Виклик форми для редагування групи
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void groupsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormEditGroup().ShowDialog();
        }
    }
}
