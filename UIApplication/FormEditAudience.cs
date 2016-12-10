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
    public partial class FormEditAudience : Form
    {
        ProgramLogicDll.ConnectDb dataBase = new ProgramLogicDll.ConnectDb();
        List<ProgramLogicDll.Computer> computers = new List<ProgramLogicDll.Computer>();
        public FormEditAudience()
        {
            InitializeComponent();
        }

        private void FormEditAudience_Load(object sender, EventArgs e)
        {
            UpdateAudiences();
        }

        private void UpdateAudiences()
        {
            comboBox1.Items.Clear(); comboBox1.Text = string.Empty;
            foreach (var item in dataBase.Audiences)
                comboBox1.Items.Add(item.AudienceNumber);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int audienceNumber = int.Parse(comboBox1.SelectedItem.ToString());
            var Audience = dataBase.Audiences.Where(number => number.AudienceNumber == audienceNumber).FirstOrDefault();

            listBox1.Items.Clear();
            foreach (var item in dataBase.Computers)
            {
                try
                {
                    if (item.Audiences == null)
                        listBox1.Items.Add(item.ComputerId);
                }
                catch { }
            }

            listBox2.Items.Clear();
            foreach (var item in Audience.Computers)
                listBox2.Items.Add(item.ComputerId);

            textBox1.Text = Audience.AudienceNumber.ToString();
            textBox2.Text = Audience.NumberOfSeats.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                listBox2.Items.Add(listBox1.SelectedItem);
                int Id = int.Parse(listBox1.SelectedItem.ToString());
                computers.Add(dataBase.Computers.Where(id => id.ComputerId == Id).FirstOrDefault());
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            }
            else
            {
                MessageBox.Show("Choise computer", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox2.SelectedIndex != -1)
            {
                listBox1.Items.Add(listBox2.SelectedItem);
                int Id = int.Parse(listBox2.SelectedItem.ToString());
                computers.Remove(dataBase.Computers.Where(id => id.ComputerId == Id).FirstOrDefault());
                dataBase.Computers.Where(id => id.ComputerId == Id).FirstOrDefault().Audiences = null;
                dataBase.SaveChanges();
                listBox2.Items.RemoveAt(listBox2.SelectedIndex);
            }
            else
            {
                MessageBox.Show("Choise computer", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != null && textBox2.Text != null)
            {
                int audienceNumber = int.Parse(textBox1.Text);

                int Id = int.Parse(comboBox1.SelectedItem.ToString());
                var Audience = dataBase.Audiences.Where(number => number.AudienceNumber == Id).FirstOrDefault();
                Audience.AudienceNumber = int.Parse(textBox1.Text);
                Audience.NumberOfSeats = int.Parse(textBox2.Text);
                Audience.Computers = computers;
                dataBase.SaveChanges();

                foreach (var item in computers)
                {
                    dataBase.Computers.Where(id => id.ComputerId == item.ComputerId).FirstOrDefault().Audiences = dataBase.Audiences.Where(number => number.AudienceNumber == audienceNumber).FirstOrDefault();
                    dataBase.SaveChanges();
                }
                textBox1.Text = textBox2.Text = string.Empty;
                listBox1.Items.Clear(); listBox2.Items.Clear(); computers.Clear(); UpdateAudiences();
                MessageBox.Show("Audience edited", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Enter all fields or choise audience", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
