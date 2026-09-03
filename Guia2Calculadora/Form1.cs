using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Guia2Calculadora
{
    public partial class Form1 : Form
    {
        private enum entrada
        {
            NINGUNA,
            DIGITO,
            OPERADOR,
            CE,
            MEMMAS
        }
        private entrada ultimaentrada;
        private double memoria;
        private bool comaDecimal;
        private char operador;
        private byte numOperador;
        private double ope1;
        private double ope2;
        public Form1()
        {
            InitializeComponent();
            ultimaentrada = entrada.NINGUNA;
            comaDecimal = false;
            operador = '\0';
            numOperador = 0;
            ope1 = 0;
            ope2 = 0;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void boton0_Click(object sender, EventArgs e)
        {
            Button objButton = (Button)sender;
            if (ultimaentrada !=entrada.DIGITO)
            {
                if (objButton.Text == "0") return;
                etPantalla.Text = "";
                ultimaentrada = entrada.DIGITO;
                comaDecimal = false;
            }
            etPantalla.Text += objButton.Text;
        }

        private void boton1_Click(object sender, EventArgs e)
        {
            Button objButton = (Button)sender;
            if (ultimaentrada != entrada.DIGITO)
            {
                if (objButton.Text == "0") return;
                etPantalla.Text = "";
                ultimaentrada = entrada.DIGITO;
                comaDecimal = false;
            }
            etPantalla.Text += objButton.Text;

        }

        private void boton2_Click(object sender, EventArgs e)
        {
            Button objButton = (Button)sender;
            if (ultimaentrada != entrada.DIGITO)
            {
                if (objButton.Text == "0") return;
                etPantalla.Text = "";
                ultimaentrada = entrada.DIGITO;
                comaDecimal = false;
            }
            etPantalla.Text += objButton.Text;
        }

        private void boton3_Click(object sender, EventArgs e)
        {
            Button objButton = (Button)sender;
            if (ultimaentrada != entrada.DIGITO)
            {
                if (objButton.Text == "0") return;
                etPantalla.Text = "";
                ultimaentrada = entrada.DIGITO;
                comaDecimal = false;
            }
            etPantalla.Text += objButton.Text;
        }

        private void boton4_Click(object sender, EventArgs e)
        {
            Button objButton = (Button)sender;
            if (ultimaentrada != entrada.DIGITO)
            {
                if (objButton.Text == "0") return;
                etPantalla.Text = "";
                ultimaentrada = entrada.DIGITO;
                comaDecimal = false;
            }
            etPantalla.Text += objButton.Text;
        }

        private void boton5_Click(object sender, EventArgs e)
        {
            Button objButton = (Button)sender;
            if (ultimaentrada != entrada.DIGITO)
            {
                if (objButton.Text == "0") return;
                etPantalla.Text = "";
                ultimaentrada = entrada.DIGITO;
                comaDecimal = false;
            }
            etPantalla.Text += objButton.Text;
        }

        private void boton6_Click(object sender, EventArgs e)
        {
            Button objButton = (Button)sender;
            if (ultimaentrada != entrada.DIGITO)
            {
                if (objButton.Text == "0") return;
                etPantalla.Text = "";
                ultimaentrada = entrada.DIGITO;
                comaDecimal = false;
            }
            etPantalla.Text += objButton.Text;
        }

        private void boton7_Click(object sender, EventArgs e)
        {
            Button objButton = (Button)sender;
            if (ultimaentrada != entrada.DIGITO)
            {
                if (objButton.Text == "0") return;
                etPantalla.Text = "";
                ultimaentrada = entrada.DIGITO;
                comaDecimal = false;
            }
            etPantalla.Text += objButton.Text;
        }

        private void boton8_Click(object sender, EventArgs e)
        {
            Button objButton = (Button)sender;
            if (ultimaentrada != entrada.DIGITO)
            {
                if (objButton.Text == "0") return;
                etPantalla.Text = "";
                ultimaentrada = entrada.DIGITO;
                comaDecimal = false;
            }
            etPantalla.Text += objButton.Text;
        }

        private void boton9_Click(object sender, EventArgs e)
        {
            Button objButton = (Button)sender;
            if (ultimaentrada != entrada.DIGITO)
            {
                if (objButton.Text == "0") return;
                etPantalla.Text = "";
                ultimaentrada = entrada.DIGITO;
                comaDecimal = false;
            }
            etPantalla.Text += objButton.Text;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void botonpunto_Click(object sender, EventArgs e)
        {
            Button objButton = (Button)sender;
            if (ultimaentrada != entrada.DIGITO)
            {
                if (objButton.Text == "0") return;
                ultimaentrada = entrada.DIGITO;
            }
            else if (comaDecimal == false) ;
            etPantalla.Text = etPantalla.Text+",";
            comaDecimal = true;
        }

        private void botonsuma_Click(object sender, EventArgs e)
        {
            Button objButton = (Button)sender;
            string textoboton = objButton.Text;

            if (numOperador == 0 && textoboton[0] == '-') ;
            ultimaentrada = entrada.DIGITO;
            if (ultimaentrada == entrada.DIGITO)
                numOperador += 1;
            if (numOperador == 1)
                ope1 = double.Parse(etPantalla.Text);
            else if (numOperador == 2)
            {
                ope2 = double.Parse(etPantalla.Text);
                switch (operador)
                {
                    case '+':
                        ope1 += ope2;
                        break;
                    case '-':
                        ope1 -= ope2;
                        break;
                    case '*':
                        ope1 *= ope2;
                        break;
                    case '/':
                        ope1 /= ope2;
                        break;
                    case '=':
                        ope1 = ope2;
                        break;
                }
                etPantalla.Text=ope1.ToString();
                numOperador = 1;
            }
            operador = textoboton[0];
            ultimaentrada = entrada.OPERADOR;
        }

        private void botonresta_Click(object sender, EventArgs e)
        {
            Button objButton = (Button)sender;
            string textoboton = objButton.Text;

            if (numOperador == 0 && textoboton[0] == '-');
            ultimaentrada = entrada.DIGITO;
            if (ultimaentrada == entrada.DIGITO)
                numOperador += 1;
            if (numOperador == 1)
                ope1 = double.Parse(etPantalla.Text);
            else if (numOperador == 2)
            {
                ope2 = double.Parse(etPantalla.Text);
                switch (operador)
                {
                    case '+':
                        ope1 += ope2;
                        break;
                    case '-':
                        ope1 -= ope2;
                        break;
                    case '*':
                        ope1 *= ope2;
                        break;
                    case '/':
                        ope1 /= ope2;
                        break;
                    case '=':
                        ope1 = ope2;
                        break;
                }
                etPantalla.Text = ope1.ToString();
                numOperador = 1;
            }
            operador = textoboton[0];
            ultimaentrada = entrada.OPERADOR;

        }

        private void botonmultiplicacion_Click(object sender, EventArgs e)
        {
            Button objButton = (Button)sender;
            string textoboton = objButton.Text;

            if (numOperador == 0 && textoboton[0] == '-') ;
            ultimaentrada = entrada.DIGITO;
            if (ultimaentrada == entrada.DIGITO)
                numOperador += 1;
            if (numOperador == 1)
                ope1 = double.Parse(etPantalla.Text);
            else if (numOperador == 2)
            {
                ope2 = double.Parse(etPantalla.Text);
                switch (operador)
                {
                    case '+':
                        ope1 += ope2;
                        break;
                    case '-':
                        ope1 -= ope2;
                        break;
                    case '*':
                        ope1 *= ope2;
                        break;
                    case '/':
                        ope1 /= ope2;
                        break;
                    case '=':
                        ope1 = ope2;
                        break;
                }
                etPantalla.Text = ope1.ToString();
                numOperador = 1;
            }
            operador = textoboton[0];
            ultimaentrada = entrada.OPERADOR;
        }

        private void botondivision_Click(object sender, EventArgs e)
        {
            Button objButton = (Button)sender;
            string textoboton = objButton.Text;

            if (numOperador == 0 && textoboton[0] == '-') ;
            ultimaentrada = entrada.DIGITO;
            if (ultimaentrada == entrada.DIGITO)
                numOperador += 1;
            if (numOperador == 1)
                ope1 = double.Parse(etPantalla.Text);
            else if (numOperador == 2)
            {
                ope2 = double.Parse(etPantalla.Text);
                switch (operador)
                {
                    case '+':
                        ope1 += ope2;
                        break;
                    case '-':
                        ope1 -= ope2;
                        break;
                    case '*':
                        ope1 *= ope2;
                        break;
                    case '/':
                        ope1 /= ope2;
                        break;
                    case '=':
                        ope1 = ope2;
                        break;
                }
                etPantalla.Text = ope1.ToString();
                numOperador = 1;
            }
            operador = textoboton[0];
            ultimaentrada = entrada.OPERADOR;
        }

        private void botonigual_Click(object sender, EventArgs e)
        {
            Button objButton = (Button)sender;
            string textoboton = objButton.Text;

            if (numOperador == 0 && textoboton[0] == '-') ;
            ultimaentrada = entrada.DIGITO;
            if (ultimaentrada == entrada.DIGITO)
                numOperador += 1;
            if (numOperador == 1)
                ope1 = double.Parse(etPantalla.Text);
            else if (numOperador == 2)
            {
                ope2 = double.Parse(etPantalla.Text);
                switch (operador)
                {
                    case '+':
                        ope1 += ope2;
                        break;
                    case '-':
                        ope1 -= ope2;
                        break;
                    case '*':
                        ope1 *= ope2;
                        break;
                    case '/':
                        ope1 /= ope2;
                        break;
                    case '=':
                        ope1 = ope2;
                        break;
                }
                etPantalla.Text = ope1.ToString();
                numOperador = 1;
            }
            operador = textoboton[0];
            ultimaentrada = entrada.OPERADOR;
        }

        private void botonC_Click(object sender, EventArgs e)
        {
            etPantalla.Text = "0,";
            ultimaentrada = entrada.NINGUNA;
            comaDecimal = false;
            operador = '\0';
            numOperador = 0;
            ope1 = 0;
            ope2 = 0;
        }

        private void botonCE_Click(object sender, EventArgs e)
        {
            etPantalla.Text = "0,";
            ultimaentrada = entrada.CE;
            comaDecimal=false;
        }

        private void botonpotencia_Click(object sender, EventArgs e)
        {
            double ope1;
            double ope2;
            double r;
            r = Math.Pow(ope1 = double.Parse(etPantalla.Text), 2);
            etPantalla.Text=r.ToString();
        }

        private void botonraiz_Click(object sender, EventArgs e)
        {
            double raiz;
            raiz=Math.Sqrt(double.Parse(etPantalla.Text));
            etPantalla.Text=raiz.ToString();
        }

        private void botonporcentaje_Click(object sender, EventArgs e)
        {
            double resultado;
            if (ultimaentrada == entrada.DIGITO)
            {
                resultado = ope1 * double.Parse(etPantalla.Text) / 100;
                etPantalla.Text = resultado.ToString();
                botonigual.PerformClick();
                botonpotencia.Focus();
            }
        }

        private void botonmasmenos_Click(object sender, EventArgs e)
        {
            double r;
            r=double.Parse(etPantalla.Text);
            etPantalla.Text = r.ToString();
        }

        private void botonMsuma_Click(object sender, EventArgs e)
        {
            memoria += double.Parse(etPantalla.Text);
            ultimaentrada = entrada.MEMMAS;
        }

        private void botonMR_Click(object sender, EventArgs e)
        {
            memoria += double.Parse(etPantalla.Text);
            ultimaentrada = entrada.MEMMAS;
        }

        private void botonMC_Click(object sender, EventArgs e)
        {
            memoria += double.Parse(etPantalla.Text);
            ultimaentrada = entrada.MEMMAS;
        }
    }
}
