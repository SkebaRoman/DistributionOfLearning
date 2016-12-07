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
        List<ProgramLogicDll.Computer> allComputers = new List<ProgramLogicDll.Computer>();
        List<ProgramLogicDll.Computer> selecterComputers = new List<ProgramLogicDll.Computer>();
        public FormAddAudience()
        {
            InitializeComponent();
        }

        private void FormAddAudience_Load(object sender, EventArgs e)
        {
            allComputers = dataBase.Computers.ToList();
            foreach (var item in allComputers)
                if (item.Audiences == null)
                    listBox1.Items.Add(item.ComputerId + " " + item.GraphicsCard + " " + item.Processor + " " + item.RAM);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox2.SelectedIndex != -1)
                listBox2.Items.RemoveAt(listBox2.SelectedIndex);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != null && textBox2.Text != null)
            {

            }
        }
    }
}
