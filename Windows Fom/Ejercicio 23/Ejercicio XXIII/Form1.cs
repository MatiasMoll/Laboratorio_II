using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Moneda;


namespace Ejercicio_XXIII
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Euros_Click(object sender, EventArgs e)
        {
            double ingreso;
            if(double.TryParse(TxtEuro.Text, out ingreso))
            {
                Peso p = new Peso(ingreso);
                Dolar d = new Dolar(ingreso);
                ResEuroEuro.Text = ingreso.ToString();
                ResEuroDolar.Text = ((Euro)d).GetCantidad().ToString();
                ResEuroPeso.Text = ((Euro)p).GetCantidad().ToString();
            }else
            {
                ResEuroEuro.Text = "0";
                ResEuroDolar.Text = "0";
                ResEuroPeso.Text = "0";
            }
        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void Dolars_Click(object sender, EventArgs e)
        {
            double ingreso;
            if (double.TryParse(TxtDolar.Text, out ingreso))
            {
                Peso p = new Peso(ingreso);
                Euro d = new Euro(ingreso);
                ResDolarDolar.Text = ingreso.ToString();
                ResDolarEuro.Text = ((Dolar)d).GetCantidad().ToString();
                ResDolarPeso.Text = ((Dolar)p).GetCantidad().ToString();
                
            }
            else
            {
                ResEuroEuro.Text = "0";
                ResEuroDolar.Text = "0";
                ResEuroPeso.Text = "0";
            }
        }

        private void Pesos_Click(object sender, EventArgs e)
        {
            double ingreso;
            if (double.TryParse(TxtEuro.Text, out ingreso))
            {
                Euro p = new Euro(ingreso);
                Dolar d = new Dolar(ingreso);
                ResPesoPeso.Text = ingreso.ToString();
                ResPesoDolar.Text = ((Peso)d).GetCantidad().ToString();
                ResPesoEuro.Text = ((Peso)p).GetCantidad().ToString();
            }
            else
            {
                ResEuroEuro.Text = "0";
                ResEuroDolar.Text = "0";
                ResEuroPeso.Text = "0";
            }
        }

        private void MaskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void MaskedTextBox3_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void Cotizacion_Click(object sender, EventArgs e)
        {
            textBox1.Text = (Euro.GetCotizacion()).ToString();
            textBox1.Enabled = false;
            textBox2.Text = (Dolar.GetCotizacion()).ToString();
            textBox2.Enabled = false;
            textBox3.Text = (Peso.GetCotizacion()).ToString();
            textBox3.Enabled = false;

        }
    }
}
