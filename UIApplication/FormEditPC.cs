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
    public partial class FormEditPC : Form
    {
        ProgramLogicDll.ConnectDb dataBase = new ProgramLogicDll.ConnectDb();
        List<ProgramLogicDll.Software> softwares = new List<ProgramLogicDll.Software>();
        public FormEditPC()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var computer = dataBase.Computers.Where(computerId => computerId.ComputerId == int.Parse(comboBox1.SelectedItem.ToString())).FirstOrDefault();
            textBox1.Text = computer.GraphicsCard;
            textBox2.Text = computer.Processor;
            textBox3.Text = computer.RAM.ToString();

            foreach (var item in dataBase.Computers.Where(computerId => computerId.ComputerId == int.Parse(comboBox1.SelectedItem.ToString())).FirstOrDefault().Softwares)
            {
                listBox2.Items.Add(item.Name);
                softwares.Add(item);
            }
        }

        private void FormEditPC_Load(object sender, EventArgs e)
        {
            foreach (var item in dataBase.Computers.Where(computerId => computerId.ComputerId == int.Parse(comboBox1.SelectedItem.ToString())).FirstOrDefault().Softwares)
                listBox1.Items.Add(item.Name);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex!=-1)
            {
                listBox2.Items.Add(listBox1.SelectedItem);
                softwares.Add(dataBase.Softwares.Where(soft=>soft.Name==listBox1.SelectedItems[0].ToString()).FirstOrDefault());
                listBox2.Items.RemoveAt(listBox2.SelectedIndex);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox2.SelectedIndex!=-1)
            {
                listBox1.Items.Add(listBox2.SelectedItem);
                softwares.RemoveAt(listBox2.SelectedIndex);
                listBox2.Items.RemoveAt(listBox2.SelectedIndex);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var computer = dataBase.Computers.Where(computerId => computerId.ComputerId == int.Parse(comboBox1.SelectedItem.ToString())).FirstOrDefault();
            computer.GraphicsCard = textBox1.Text;
            computer.Processor = textBox2.Text;
            computer.RAM = int.Parse(textBox3.Text);
            computer.Softwares = softwares;
            dataBase.SaveChanges();
        }
    }
}
