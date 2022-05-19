using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Teht_4_Switch
{
    public partial class PaaForms : Form
    {
        

        public PaaForms()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ButtonClick(object sender, EventArgs e)

        {

            Button painettuNappi = sender as Button;

        }

        private void bt_Valinta1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Valinta1", "Huom");
        }

        private void bt_Valinta2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Valinta2", "Huom");
        }

        private void bt_Valinta3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Valinta3", "Huom");
        }

        private void bt_Valinta4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Valinta4", "Huom");
        }

        private void bt_Default_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Default", "Huom");
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

    }
}
