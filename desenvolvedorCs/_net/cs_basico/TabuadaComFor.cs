using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EstudoRepeteticao
{
    public partial class frmEstruturaRepeticao : Form
    {
        public frmEstruturaRepeticao()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int numero = Convert.ToInt32(txbNumero.Text);
            // for
            for (int i = 0; i <= 10; i++)
            {
                lsbResultados.Items.Add(string.Format("{0} X {1} = {2}", numero, i, numero * i));
            }
        }
    }
}
