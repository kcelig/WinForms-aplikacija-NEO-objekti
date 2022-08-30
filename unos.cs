using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Neo_objekti
{
    public partial class Unos : Form
    {
        public Unos()
        {
            InitializeComponent();
        }
        private void Form2_Load(object sender, EventArgs e)
        {

        }
        private void btnok_Click(object sender, EventArgs e)
        {
            if (naziv.Text == "")
            {
                MessageBox.Show("Niste unijeli ime asteroida!");
            }
            else if (!radioButton1.Checked && !radioButton2.Checked && !radioButton3.Checked)
            {
                MessageBox.Show("Niste odabrali sastav jezgre!");
            }
           else if (brzina.Text == "")
            {
                MessageBox.Show("Niste unijeli procjenjenu brzinu!");
            }
            else
            {
                this.DialogResult = DialogResult.OK;
            }
        }
        private void btnOdustani_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
