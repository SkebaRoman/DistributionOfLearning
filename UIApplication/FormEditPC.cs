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
            dataBase = new ProgramLogicDll.ConnectDb();
            int Id = int.Parse(comboBox1.SelectedItem.ToString());
            var computer = dataBase.Computers.Where(computerId => computerId.ComputerId == Id).FirstOrDefault();
            textBox1.Text = computer.GraphicsCard;
            textBox2.Text = computer.Processor;
            textBox3.Text = computer.RAM.ToString();

            foreach (var item in dataBase.Computers.Where(computerId => computerId.ComputerId == Id).FirstOrDefault().Softwares)
            {
                listBox2.Items.Add(item.Name);
                softwares.Add(item);
            }
            foreach (var item in dataBase.Softwares)
            {
                bool check = true;
                foreach (var item1 in softwares)
                    if (item.Name == item1.Name)
                        check = false;
                if (check == true)
                    listBox1.Items.Add(item.Name);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                listBox2.Items.Add(listBox1.SelectedItem);
                softwares.Add(dataBase.Softwares.Where(soft => soft.Name == listBox1.SelectedItem.ToString()).FirstOrDefault());
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            }
            else
            {
                MessageBox.Show("Choise software", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox2.SelectedIndex != -1)
            {
                listBox1.Items.Add(listBox2.SelectedItem);
                softwares.Remove(dataBase.Softwares.Where(soft => soft.Name == listBox2.SelectedItem.ToString()).FirstOrDefault());
                listBox2.Items.RemoveAt(listBox2.SelectedIndex);
            }
            else
            {
                MessageBox.Show("Choise software", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != string.Empty && textBox2.Text != string.Empty && textBox3.Text != string.Empty && comboBox1.SelectedIndex != -1)
            {
                int Id = int.Parse(comboBox1.SelectedItem.ToString());
                var computer = dataBase.Computers.Where(computerId => computerId.ComputerId == Id).FirstOrDefault();
                computer.GraphicsCard = textBox1.Text;
                computer.Processor = textBox2.Text;
                computer.RAM = int.Parse(textBox3.Text);
                computer.Softwares = softwares;
                dataBase.SaveChanges();
                textBox1.Text = textBox2.Text = textBox3.Text = string.Empty;
                listBox1.Items.Clear(); listBox2.Items.Clear();
                UpdateComputers(); softwares.Clear();
                MessageBox.Show("Computer edited", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Choise computer or add all fields", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void FormEditPC_Load(object sender, EventArgs e)
        {
            UpdateComputers();
        }

        private void UpdateComputers()
        {
            comboBox1.Items.Clear(); comboBox1.Text = string.Empty;
            foreach (var item in dataBase.Computers)
                comboBox1.Items.Add(item.ComputerId);
        }
    }
}
