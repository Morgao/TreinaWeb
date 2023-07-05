using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EstudoSwitch
{
    public partial class frmSwitch : Form
    {
        public frmSwitch()
        {
            InitializeComponent();
        }

        private void btnVerificarNumero_Click(object sender, EventArgs e)
        {
            int numeroDigitado = Convert.ToInt32(txbNumero.Text);
            // 0 1 2 3 - numero baixo
            // 4 5 6 - numero medio
            // 7 8 9 - numero alto
            switch (numeroDigitado) 
            {
                case 0:
                    MessageBox.Show("Numero Baixo");
                    break;
                case 1:
                    MessageBox.Show("Numero Baixo");
                    break;
                case 2:
                    MessageBox.Show("Numero Baixo");
                    break;
                case 3:
                    MessageBox.Show("Numero Baixo");
                    break;
                case 4:
                    MessageBox.Show("Numero Medio");
                    break;
                case 5:
                    MessageBox.Show("Numero Medio");
                    break;
                case 6:
                    MessageBox.Show("Numero Medio");
                    break;
                case 7:
                    MessageBox.Show("Numero Alto");
                    break;
                case 8:
                    MessageBox.Show("Numero Alto");
                    break;
                case 9:
                    MessageBox.Show("Numero Alto");
                default:
                    MessageBox.Show("Numero Invalido");
                    break;




            }
        }
    }
}
