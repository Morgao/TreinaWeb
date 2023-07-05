using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AreaEperimetro
{
    public partial class frmRetangulo : Form
    {


        int numero1 = 0;
        
        int numero2 = 0;
        public frmRetangulo()
        {
            InitializeComponent();
        }

        private void txbCalcular_Click(object sender, EventArgs e)
        {
            numero1 = Convert.ToInt32(txbComprimento.Text);
            numero2 = Convert.ToInt32(txbLargura.Text);
            txbArea.Text = Area(numero1, numero2).ToString();
            txbPerimetro.Text = Perimetro(numero1, numero2).ToString();

        }
        int Area(int numero1, int numero2)
        {
            int resultado = numero1 * numero2;
            return resultado;
        }

        int Perimetro(int numero1, int numero2)
        {
            int resultado = 2 * numero1 + 2 * numero2;
            return resultado;
            
        }
    }
}
