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
    public partial class FormAddPC : Form
    {
        ConnectDb dataBase = new ConnectDb();
        List<Software> softwares = new List<Software>();
        public FormAddPC()
        {
            InitializeComponent();
        }

        private void FormAddPC_Load(object sender, EventArgs e)
        {
            UpdateSoftwares();
        }

        private void UpdateSoftwares()
        {
            listBox1.Items.Clear();
            foreach (var item in dataBase.Softwares)
                listBox1.Items.Add(item.Name);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != string.Empty && textBox2.Text != string.Empty && textBox3.Text != string.Empty)
            {
                dataBase.Computers.Add(new Computer
                {
                    GraphicsCard = textBox1.Text,
                    Processor = textBox2.Text,
                    RAM = int.Parse(textBox3.Text),
                    Softwares = softwares
                });
                dataBase.SaveChanges();
                textBox1.Text = textBox2.Text = textBox3.Text = string.Empty;
                UpdateSoftwares(); listBox2.Items.Clear();
                MessageBox.Show("PC added", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Enter all fields", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex!=-1)
            {
                listBox2.Items.Add(listBox1.SelectedItem);
                softwares.Add(dataBase.Softwares.Where(soft=>soft.Name==listBox1.SelectedItem.ToString()).FirstOrDefault());
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
    }
}
