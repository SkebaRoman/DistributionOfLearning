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
    public partial class FormAddAudience : Form
    {
        ProgramLogicDll.ConnectDb dataBase = new ProgramLogicDll.ConnectDb();
        List<ProgramLogicDll.Computer> computers = new List<ProgramLogicDll.Computer>();
        public FormAddAudience()
        {
            InitializeComponent();
        }

        private void FormAddAudience_Load(object sender, EventArgs e)
        {
            foreach (var item in dataBase.Computers)
                if (item.Audiences == null)
                    listBox1.Items.Add(item.ComputerId);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox2.SelectedIndex != -1)
            {
                listBox1.Items.Add(listBox2.SelectedItems[0]);
                computers.RemoveAt(listBox2.SelectedIndex);
                listBox2.Items.RemoveAt(listBox2.SelectedIndex);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                listBox2.Items.Add(listBox1.SelectedItem);
                computers.Add(dataBase.Computers.Where(subject => subject.ComputerId == int.Parse(listBox1.SelectedItems[0].ToString())).FirstOrDefault());
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != null && textBox2.Text != null)
            {
                dataBase.Audiences.Add(new ProgramLogicDll.Audience
                {
                    AudienceNumber = int.Parse(textBox1.Text),
                    Computers = computers
                });
                dataBase.SaveChanges();
            }
        }
    }
}
