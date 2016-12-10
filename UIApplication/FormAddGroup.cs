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
    public partial class FormAddGroup : Form
    {
        ProgramLogicDll.ConnectDb dataBase = new ProgramLogicDll.ConnectDb();
        List<ProgramLogicDll.Student> students = new List<ProgramLogicDll.Student>();
        List<ProgramLogicDll.Teacher> teachers = new List<ProgramLogicDll.Teacher>();
        public FormAddGroup()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBoxStudents.SelectedIndex != -1)
            {
                listBox1.Items.Add(listBoxStudents.SelectedItem);
                students.Add(dataBase.Students.Where(Id => Id.StudentId == int.Parse(listBoxStudents.SelectedItem.ToString())).FirstOrDefault());
                listBoxStudents.Items.RemoveAt(listBoxStudents.SelectedIndex);
            }
        }

        private void FormAddGroup_Load(object sender, EventArgs e)
        {
            foreach (var item in dataBase.Students)
                if (item.Groups == null)
                    listBoxStudents.Items.Add(item.FirstName + " " + item.LastName);
            foreach (var item in dataBase.Teachers)
                listBoxTeachers.Items.Add(item.FirstName + " " + item.LastName);
            foreach (var item in dataBase.Semesters)
                comboBoxSemester.Items.Add(item.SemesterNumber);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                listBoxStudents.Items.Add(listBox1.SelectedItem);
                students.RemoveAt(listBox1.SelectedIndex);
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (listBoxTeachers.SelectedIndex != -1)
            {
                listBox2.Items.Add(listBoxTeachers.SelectedItem);
                teachers.Add(dataBase.Teachers.Where(Id => Id.TeacherId == int.Parse(listBoxTeachers.SelectedItem.ToString())).FirstOrDefault());
                listBoxTeachers.Items.RemoveAt(listBoxTeachers.SelectedIndex);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (listBox2.SelectedIndex != -1)
            {
                listBoxTeachers.Items.Add(listBox2.SelectedItem);
                teachers.Add(dataBase.Teachers.Where(Id => Id.TeacherId == int.Parse(listBoxTeachers.SelectedItem.ToString())).FirstOrDefault());
                listBox2.Items.RemoveAt(listBox2.SelectedIndex);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBoxGroupname.Text != string.Empty && textBoxProfession.Text != string.Empty && textBox1.Text != string.Empty && comboBoxSemester.SelectedIndex != -1)
            {
                dataBase.Groups.Add(new ProgramLogicDll.Group
                {
                    Name = textBoxGroupname.Text,
                    Profession = textBoxProfession.Text,
                    HoursOfStudy = textBox1.Text,
                    Students = students,
                    Teachers = teachers
                });
                dataBase.SaveChanges();
            }
        }
    }
}
