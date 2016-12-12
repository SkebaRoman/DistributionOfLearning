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
    public partial class FormEditGroup : Form
    {
        ProgramLogicDll.ConnectDb dataBase = new ProgramLogicDll.ConnectDb();
        List<ProgramLogicDll.Student> allStudents = new List<ProgramLogicDll.Student>();
        List<ProgramLogicDll.Teacher> allTeachers = new List<ProgramLogicDll.Teacher>();

        List<ProgramLogicDll.Student> students = new List<ProgramLogicDll.Student>();
        List<ProgramLogicDll.Teacher> teachers = new List<ProgramLogicDll.Teacher>();
        public FormEditGroup()
        {
            InitializeComponent();
        }

        private void FormEditGroup_Load(object sender, EventArgs e)
        {
            comboBox1.Items.AddRange(new string[] { "Programmer", "Administrator", "Designer" });
            foreach (var item in dataBase.Groups)
            {
                comboBox2.Items.Add(item.Name);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBoxStudents.SelectedIndex != -1)
            {
                listBox1.Items.Add(listBoxStudents.SelectedItem);
                int id = allStudents[listBoxStudents.SelectedIndex].StudentId;
                students.Add(dataBase.Students.Where(Id => Id.StudentId == id).FirstOrDefault());
                allStudents.RemoveAt(listBoxStudents.SelectedIndex);
                listBoxStudents.Items.RemoveAt(listBoxStudents.SelectedIndex);
            }
            else
            {
                MessageBox.Show("Choise student", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                listBoxStudents.Items.Add(listBox1.SelectedItem);
                int id = students[listBox1.SelectedIndex].StudentId;
                allStudents.Add(dataBase.Students.Where(Id => Id.StudentId == id).FirstOrDefault());
                students.RemoveAt(listBox1.SelectedIndex);
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            }
            else
            {
                MessageBox.Show("Choise student", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (listBoxTeachers.SelectedIndex != -1)
            {
                listBox2.Items.Add(listBoxTeachers.SelectedItem);
                int id = allTeachers[listBoxTeachers.SelectedIndex].TeacherId;
                teachers.Add(dataBase.Teachers.Where(Id => Id.TeacherId == id).FirstOrDefault());
                allTeachers.RemoveAt(listBoxTeachers.SelectedIndex);
                listBoxTeachers.Items.RemoveAt(listBoxTeachers.SelectedIndex);
            }
            else
            {
                MessageBox.Show("Choise teacher", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (listBox2.SelectedIndex != -1)
            {
                listBoxTeachers.Items.Add(listBox2.SelectedItem);
                int id = teachers[listBox2.SelectedIndex].TeacherId;
                allTeachers.Add(dataBase.Teachers.Where(Id => Id.TeacherId == id).FirstOrDefault());
                teachers.RemoveAt(listBox2.SelectedIndex);
                listBox2.Items.RemoveAt(listBox2.SelectedIndex);
            }
            else
            {
                MessageBox.Show("Choise teacher", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateGroups();
        }
        private void UpdateGroups()
        {
            foreach (var item in dataBase.Semesters)
                comboBoxSemester.Items.Add(item.SemesterNumber);
            var group = dataBase.Groups.Where(x => x.Name == comboBox2.SelectedItem.ToString()).FirstOrDefault();
            textBoxGroupname.Text = group.Name;
            textBox1.Text = group.HoursOfStudy;
            comboBoxSemester.SelectedItem = group.Semesters;
            comboBox1.SelectedItem = group.Profession;
            foreach (var item in dataBase.Students)
            {
                try
                {
                    if (item.Groups == null&&item.Profession==comboBox1.SelectedItem.ToString())
                    {
                        listBoxStudents.Items.Add(item.FirstName + " " + item.LastName);
                        allStudents.Add(item);
                    }
                }
                catch { }
            }
            allTeachers = dataBase.Teachers.ToList();
            foreach (var item in allTeachers)
                listBoxTeachers.Items.Add(item.FirstName + " " + item.LastName);
         
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBoxGroupname.Text != string.Empty && comboBox1.SelectedIndex != -1 && textBox1.Text != string.Empty && comboBoxSemester.SelectedIndex != -1)
            {
                int semestr = int.Parse(comboBoxSemester.Text);
                var group = dataBase.Groups.Where(x => x.Name == comboBox2.SelectedItem.ToString()).FirstOrDefault();

                group.Name = textBoxGroupname.Text;
                   group.Profession = comboBox1.Text;
                  group.HoursOfStudy = textBox1.Text;
                  group.Semesters = dataBase.Semesters.Where(sem => sem.SemesterNumber == semestr).FirstOrDefault();
                   group.Students = students;
                   group.Teachers = teachers;
               
                dataBase.SaveChanges();
                foreach (var item in students)
                {
                    dataBase.Students.Where(stud => stud.StudentId == item.StudentId).FirstOrDefault().Groups = dataBase.Groups.Where(id => id.Name == textBoxGroupname.Text).FirstOrDefault();
                    dataBase.SaveChanges();
                }
                foreach (var item in teachers)
                {
                    dataBase.Teachers.Where(teacher => teacher.TeacherId == item.TeacherId).FirstOrDefault().Groups.Add(dataBase.Groups.Where(id => id.Name == textBoxGroupname.Text).FirstOrDefault());
                    dataBase.SaveChanges();
                }
                textBoxGroupname.Text = textBox1.Text = string.Empty;
                listBox1.Items.Clear(); listBox2.Items.Clear();
                MessageBox.Show("Group added", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Enter all fields", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
