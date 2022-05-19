using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Teht1
{
    public partial class Form1 : Form
    {
        private string Id;

        private string Nimi()
        {
            return "Elokuvan nimi";
        }

        private string Julkaisu()
        {
            return "2017";
        }

        private string Kesto()
        {
            return "0";
        }

        private string arvio()
        {
            return "Kirjoita arvio tähän";
        }

        public Form1()
        {
            InitializeComponent();
            OletusTeksti();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            lb_arvio.Text = "";
        }


        private void tietojaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void infoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tämän sovelluksen on tehnyt Veeti Tuunainen!");
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }


        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void btTietue_Click(object sender, EventArgs e)
        {
            

            foreach (var item in this.Controls)
            {
                if (item.GetType().Equals(typeof(TextBox)))
                {
                    TextBox t1 = item as TextBox;

                    t1.Text = "";

                }
            }

            OletusTeksti();
        }

        private void OletusTeksti()
        {
            tb_Elokuva_id.Text = "0";
            lb_arvio.Text = arvio();
            tb_release.Text = System.DateTime.Today.Year.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void poistuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btTallenna_Click(object sender, EventArgs e)
        {
            if (tb_ElokuvaNimi.Text == "")
            {
                MessageBox.Show("Lisää elokuvan nimi");
                tb_ElokuvaNimi.Focus();
            }
            else if (tb_time.Text == "")
            {
                MessageBox.Show("Täytä kesto");
                tb_time.Focus();
            }
            else if (tb_release.Text == "")
            {
                MessageBox.Show("Julkaisu vuosi puuttuu");
                tb_release.Focus();
            }

            else
            {
                MessageBox.Show("Tallennus onnistui");
            }
        }

        private void btPoista_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
