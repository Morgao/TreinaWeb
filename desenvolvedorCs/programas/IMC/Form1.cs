using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMC
{
    public partial class frmIMC : Form
    {
        
        public frmIMC()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double peso = Convert.ToDouble(txbPeso.Text);
            double altura = Convert.ToDouble(txbAltura.Text);
            var imc = CalculoIMC(peso, altura);
            txbResultado.Text = imc.ToString();
            if (imc < 18.5)
            {
                MessageBox.Show("Magreza");
            }
            else if ((imc > 18.5) && (imc < 25)) 
            {
                MessageBox.Show("Normal");
            }
            else if ((imc > 25) && (imc < 30))
            {
                MessageBox.Show("Sobrepeso I");
            }
            else if ((imc > 30) && (imc < 40))
            {
                MessageBox.Show("Obesidade II");
            }
            else
            {
                MessageBox.Show("Obesidade Grave III");
            }

            //ostrarSituacao(imc);

        }
        double CalculoIMC(double peso, double altura)
        {
            double imc = (peso / (altura * altura)) * 10000;
            return imc;
        }

      

        }
    }

