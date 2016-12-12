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
    public partial class FormAddSoftware : Form
    {
        ProgramLogicDll.ConnectDb dataBase = new ProgramLogicDll.ConnectDb();
        public FormAddSoftware()
        {
            InitializeComponent();
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

        /// <summary>
        /// Метод для добавлення ПЗ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != string.Empty)
            {
                if (dataBase.Softwares.Where(soft => soft.Name == textBox1.Text).FirstOrDefault() == null)
                {
                    dataBase.Softwares.Add(new ProgramLogicDll.Software { Name = textBox1.Text });
                    dataBase.SaveChanges();
                    textBox1.Text = string.Empty;
                    MessageBox.Show("Software added", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("This software already exists", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Enter software", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
