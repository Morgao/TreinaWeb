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
                case 1:                    
                case 2:                    
                case 3:
                    MessageBox.Show("Numero Baixo");
                    break;
                case 4:
                case 5:
                case 6:
                    MessageBox.Show("Numero Médio");
                    break;            
                default:
                    MessageBox.Show("Numero Alto");
                    break;




            }
        }
    }
}
