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
    public partial class FormEditSoftware : Form
    {
        ProgramLogicDll.ConnectDb dataBase = new ProgramLogicDll.ConnectDb();
        public FormEditSoftware()
        {
            InitializeComponent();
        }

        private void FormEditSoftware_Load(object sender, EventArgs e)
        {
            foreach (var item in dataBase.Softwares)
                comboBox1.Items.Add(item.Name);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Text = dataBase.Softwares.Where(software => software.Name == comboBox1.SelectedItem.ToString()).FirstOrDefault().Name;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataBase.Softwares.Where(software => software.Name == comboBox1.SelectedItem.ToString()).FirstOrDefault().Name = textBox1.Text;
            dataBase.SaveChanges();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
