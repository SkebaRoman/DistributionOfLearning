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
        ConnectDb db = new ConnectDb();
        public FormAddPC()
        {
            InitializeComponent();
        }

        private void FormAddPC_Load(object sender, EventArgs e)
        {
           
            foreach (var item in db.Softwares.ToList())
                listBox1.Items.Add(item);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text!=string.Empty&&textBox2.Text!=string.Empty)
            {
                if (listBox1.SelectedIndex == -1)
                {
                    db.Computers.Add(new Computer { GraphicsCard = textBox2.Text, Processor = textBox1.Text, RAM = (int)numericUpDown1.Value, Softwares = new List<Software>(), Audiences = null });

                }
                else
                {
                    db.Computers.Add(new Computer { GraphicsCard = textBox2.Text, Processor = textBox1.Text, RAM = (int)numericUpDown1.Value, Softwares = new List<Software>() { db.Softwares.SingleOrDefault(x => x.Name == listBox1.SelectedItem.ToString()) }, Audiences = null });
                        }

            }
            db.SaveChanges();
            this.Close();
        }
    }
}
