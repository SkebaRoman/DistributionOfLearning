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
    public partial class FormAddGroup : Form
    {
        public FormAddGroup()
        {
            InitializeComponent();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxGroupname.Text) || string.IsNullOrWhiteSpace(textBoxProfession.Text))
            {
                MessageBox.Show("Some fields are empty!");
                return;
            }

            // TODO: logic
        }
    }
}
