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

        /// <summary>
        /// Обновлення ComboBox з ПЗ
        /// </summary>
        private void UpdateSoftwares()
        {
            comboBox1.Items.Clear(); comboBox1.Text = string.Empty;
            foreach (var item in dataBase.Softwares)
                comboBox1.Items.Add(item.Name);
        }

        private void FormEditSoftware_Load(object sender, EventArgs e)
        {
            UpdateSoftwares();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Text = dataBase.Softwares.Where(software => software.Name == comboBox1.SelectedItem.ToString()).FirstOrDefault().Name;
        }

        /// <summary>
        /// Метод для збереження відредактованого ПЗ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex != -1 && textBox1.Text != string.Empty)
            {
                if (dataBase.Softwares.Where(software => software.Name == textBox1.Text).FirstOrDefault() == null)
                {
                    dataBase.Softwares.Where(software => software.Name == comboBox1.SelectedItem.ToString()).FirstOrDefault().Name = textBox1.Text;
                    dataBase.SaveChanges();
                    textBox1.Text = string.Empty;
                    UpdateSoftwares();
                    MessageBox.Show("Software edited", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("This software already exists", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Choise software", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// Закриття форми
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
