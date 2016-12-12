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
        List<ProgramLogicDll.Group> Groups = new List<ProgramLogicDll.Group>();
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
            computers = new List<ProgramLogicDll.Computer>();
            Groups = new List<ProgramLogicDll.Group>();
            comboBox1.Items.Clear(); comboBox1.Text = string.Empty;
            foreach (var item in dataBase.Audiences)
                comboBox1.Items.Add(item.AudienceNumber);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            computers = new List<ProgramLogicDll.Computer>();
            Groups = new List<ProgramLogicDll.Group>();

            int audienceNumber = int.Parse(comboBox1.SelectedItem.ToString());
            var Audience = dataBase.Audiences.Where(number => number.AudienceNumber == audienceNumber).FirstOrDefault();

            listBox2.Items.Clear(); listBox1.Items.Clear();
            listBox3.Items.Clear(); listBox4.Items.Clear();
            foreach (var item in dataBase.Computers)
            {
                try
                {
                    if (item.Audiences == null)
                        listBox1.Items.Add(item.ComputerId);
                }
                catch { }
            }

            foreach (var item in dataBase.Groups)
            {
                try
                {
                    if (item.Audiences == null)
                        listBox3.Items.Add(item.Name);
                }
                catch { }
            }

            foreach (var item in Audience.Computers)
            {
                listBox2.Items.Add(item.ComputerId);
                computers.Add(item);
            }

            foreach (var item in Audience.Groups)
            {
                listBox4.Items.Add(item.Name);
                Groups.Add(item);
            }

            textBox1.Text = Audience.AudienceNumber.ToString();
            textBox2.Text = Audience.NumberOfSeats.ToString();
        }

        /// <summary>
        /// Метод для добавлення компютера в аудиторію
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Метод для видалення компютера з аудиторії
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Закриття форми
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Метод для зберігання відредактованої аудиторії
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != null && textBox2.Text != null)
            {
                if (Convert.ToInt32(textBox2.Text) > listBox2.Items.Count)
                {
                    int audienceNumber = int.Parse(textBox1.Text);

                    int Id = int.Parse(comboBox1.SelectedItem.ToString());
                    var Audience = dataBase.Audiences.Where(number => number.AudienceNumber == Id).FirstOrDefault();
                    Audience.AudienceNumber = int.Parse(textBox1.Text);
                    Audience.NumberOfSeats = int.Parse(textBox2.Text);
                    Audience.Computers = computers;
                    Audience.Groups = Groups;
                    dataBase.SaveChanges();

                    foreach (var item in computers)
                    {
                        dataBase.Computers.Where(id => id.ComputerId == item.ComputerId).FirstOrDefault().Audiences = dataBase.Audiences.Where(number => number.AudienceNumber == audienceNumber).FirstOrDefault();
                        dataBase.SaveChanges();
                    }
                    foreach (var item in Groups)
                    {
                        dataBase.Groups.Where(id => id.GroupId == item.GroupId).FirstOrDefault().Audiences = dataBase.Audiences.Where(number => number.AudienceNumber == audienceNumber).FirstOrDefault();
                        dataBase.SaveChanges();
                    }
                    textBox1.Text = textBox2.Text = string.Empty;
                    listBox1.Items.Clear(); listBox2.Items.Clear(); listBox3.Items.Clear(); listBox4.Items.Clear(); UpdateAudiences();
                    MessageBox.Show("Audience edited", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Enter all fields or choise audience", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// Метод для добавлення групи в аудиторію
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button5_Click(object sender, EventArgs e)
        {
            if (listBox3.SelectedIndex != -1)
            {
                listBox4.Items.Add(listBox3.SelectedItem);
                Groups.Add(dataBase.Groups.Where(id => id.Name == listBox3.SelectedItem.ToString()).FirstOrDefault());
                listBox3.Items.RemoveAt(listBox3.SelectedIndex);
            }
            else
            {
                MessageBox.Show("Choise Group", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// Метод для видалення групи з аудиторії
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button7_Click(object sender, EventArgs e)
        {
            if (listBox4.SelectedIndex != -1)
            {
                listBox3.Items.Add(listBox4.SelectedItem);
                Groups.Remove(dataBase.Groups.Where(id => id.Name == listBox4.SelectedItem.ToString()).FirstOrDefault());
                listBox4.Items.RemoveAt(listBox4.SelectedIndex);
            }
            else
            {
                MessageBox.Show("Choise Group", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
