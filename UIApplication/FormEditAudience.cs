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
            foreach (var item in dataBase.Audiences)
                comboBox1.Items.Add(item.AudienceNumber);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var Audience = dataBase.Audiences.Where(number => number.AudienceNumber == int.Parse(comboBox1.SelectedItem.ToString())).FirstOrDefault();
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
                computers.Add(dataBase.Computers.Where(subject => subject.ComputerId == int.Parse(listBox1.SelectedItems[0].ToString())).FirstOrDefault());
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox2.SelectedIndex!=-1)
            {
                listBox1.Items.Add(listBox2.SelectedItem);
                computers.RemoveAt(listBox2.SelectedIndex);
                listBox2.Items.RemoveAt(listBox2.SelectedIndex);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var Audience = dataBase.Audiences.Where(number => number.AudienceNumber == int.Parse(comboBox1.SelectedItem.ToString())).FirstOrDefault();
            Audience.AudienceNumber = int.Parse(textBox1.Text);
            Audience.NumberOfSeats = int.Parse(textBox2.Text);
            Audience.Computers = computers;
            dataBase.SaveChanges();
        }
    }
}
