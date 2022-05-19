using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace teht_5_for
{
    public partial class PaaForms : Form
    {
        public PaaForms()
        {
            InitializeComponent();
        }

        private void bt_Start_Click(object sender, EventArgs e)
        {
            Thread OmaSaie;

            OmaSaie = new Thread(new ThreadStart(this.SaieProceduuri));

            OmaSaie.Start();
        }

        private void SaieProceduuri()

        {

            Int32 Kierrokset = Convert.ToInt32(tb_Numero.Text);



            for (Int32 i = 0; i < Kierrokset; i++)

            {

                string uusiNumero = (i + 1).ToString();

                this.AsetaTeksti(uusiNumero);

                Thread.Sleep(10);

            }
        }

        delegate void StringArgReturningVoidDelegate(string texti);

        private void AsetaTeksti(string texti)

        {

            if (this.lb_Numerot.InvokeRequired)

            { 

                StringArgReturningVoidDelegate d = new StringArgReturningVoidDelegate(AsetaTeksti);

                this.Invoke(d, new object[] { texti });

            }

            else

            {  

                this.lb_Numerot.Text = texti;

            }

        }
    }
}
