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

        private void FormAddSubject_Load(object sender, EventArgs e)
        {
            foreach (var item in db.Semesters)
            {
                listView1.Items.Add(item.SemesterNumber.ToString());
            } 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Semester t;
            if (listView1.SelectedItems.Count > 0)
                t = db.Semesters.SingleOrDefault(x => x.SemesterNumber.ToString() == listView1.SelectedItems[0].ToString());
            else
                t = null;
            db.Subjects.Add(new Subject() {Name=textBox1.Text,Teachers=null,Semesters=t});
            db.SaveChanges();
            this.Close();
        }
    }
}
