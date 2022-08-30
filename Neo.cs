using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Neo_objekti
{
    public partial class Neo : Form
    {
        public Neo()
        {
            InitializeComponent();
        }
        public void Pohrana()
        {
            string vrijednosti = "";
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                for (int j = 0; j < dataGridView1.Columns.Count; j++)
                {
                    vrijednosti = vrijednosti + (string)dataGridView1.Rows[i].Cells[j].Value + "\n";
                }
   
            }
            File.WriteAllText(Application.StartupPath + "\\asteroidi.txt", vrijednosti);
        }
        public void Ispis()
        {
            if (File.Exists(Application.StartupPath + "\\asteroidi.txt"))
            {
                string vrijednosti = File.ReadAllText(Application.StartupPath + "\\asteroidi.txt");
                char[] znak = new char[1];
                znak[0] = '\n';
                string[] v = vrijednosti.Split(znak, StringSplitOptions.RemoveEmptyEntries);
                for (int i = 0; i < v.Length; i = i + 4)
                {
                    dataGridView1.Rows.Add(v[i], v[i + 1], v[i + 2], v[i + 3]);
                }
               
            }

        }
            private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            fgraf forma = new fgraf();
        }
        private void oAutoruToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fgraf nForm = new fgraf();
            nForm.TopLevel = false;
            nForm.Show();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
        private void btnDodaj_Click(object sender, EventArgs e)
        {
            Unos forma = new Unos();
            {

                if (forma.ShowDialog() == DialogResult.OK)
                {
                   
                    string opasan = "";
                    string jezgra = "";
                    if (forma.cbxOpasan.Checked)
                    {
                        opasan = "opasan";
                    }
                    else
                    {
                        opasan = "nije opasan";
                    }

                    if (forma.radioButton1.Checked)
                    {
                        jezgra = "silikatna";
                    }
                    if (forma.radioButton2.Checked)
                    {
                        jezgra = "karbonska";
                    }
                    if (forma.radioButton3.Checked)
                    {
                        jezgra = "metalna";
                    }

                    dataGridView1.Rows.Add(forma.naziv.Text.Trim(), opasan, jezgra, forma.brzina.Text);
                }
                double x = dataGridView1.Rows.Count;
                double brojac = 0;
                double y = 0;
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    if ("opasan" == (string)dataGridView1.Rows[i].Cells[1].Value)
                    {
                        brojac = brojac + 1;
                        y = brojac / x;

                    }
                }
                y = y * 100;
                y = Math.Round(y, 2);
                brzine.Text = y.ToString();
                Pohrana();                                   
            }
        }
        private void btnuredi_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count ==  0)
            {
                return;
            }
            Unos forma = new Unos();
            forma.naziv.Text = (String)dataGridView1.SelectedRows[0].Cells[0].Value;       
            if (forma.ShowDialog() == DialogResult.OK)
            {             
                string opasan = "";
                string jezgra = "";
                if (forma.cbxOpasan.Checked)
                {
                    opasan = "opasan";
                }
                else
                {
                    opasan = "nije opasan";
                }

                if (forma.radioButton1.Checked)
                {
                    jezgra = "silikatna";
                }
                if (forma.radioButton2.Checked)
                {
                    jezgra = "karbonska";
                }
                if (forma.radioButton3.Checked)
                {
                    jezgra = "metalna";
                }
                dataGridView1.Rows.Remove(dataGridView1.SelectedRows[0]);
                dataGridView1.Rows.Add(forma.naziv.Text.Trim(), opasan, jezgra, forma.brzina.Text);
                double x = dataGridView1.Rows.Count;
                double brojac = 0;
                double y = 0;

                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    if ("opasan" == (string)dataGridView1.Rows[i].Cells[1].Value)
                    {
                        brojac = brojac + 1;
                        y = brojac / x;
                    }
                }
                y = y * 100;
                y = Math.Round(y, 2);
                brzine.Text = y.ToString();
                Pohrana();
            }         
        }
        private void btndel_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                return;
            }
            dataGridView1.Rows.Remove(dataGridView1.SelectedRows[0]);
            double x = dataGridView1.Rows.Count;
            double brojac = 0;
            double y = 0;

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if ("opasan" == (string)dataGridView1.Rows[i].Cells[1].Value)
                {
                    brojac = brojac + 1;
                    y = brojac / x;

                }
            }
            y = y * 100;
            y = Math.Round(y, 2);
            brzine.Text = y.ToString();
            Pohrana();
        }
        private void grafičkiPrikazToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }
        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            fgraf nForm = new fgraf();
            nForm.TopLevel = true;
            nForm.Show();
            nForm.graf1.Series["Series1"].Points.Clear();
            int b = dataGridView1.Rows.Count;
            string x = "";
            int y = 0;
            for (int i = 0; i < b; i++)
            {
                x = Convert.ToString(dataGridView1.Rows[i].Cells[0].Value);
                y = Convert.ToInt32(dataGridView1.Rows[i].Cells[3].Value);
                nForm.graf1.Series["Series1"].Points.AddXY(x, y);

            }
        }
        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {         
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result  = MessageBox.Show("Želite li izaći iz programa?", "Izlazak", buttons);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

            Ispis();
        }
        private void oAutoruToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            
        }
        private void oAutoruToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            autor nForm = new autor();
            nForm.TopLevel = true;
            nForm.Show();
        }
    }
}
