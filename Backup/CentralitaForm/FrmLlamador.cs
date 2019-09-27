using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using CentralitaForm;

namespace CentralitaForm
{
    public partial class FrmLlamador : Form
    {
        Centralita llamada;
        TextBox txtFoco = new TextBox();

        public Centralita Llamada
        {
            get
            {
                return llamada;
            }
        }
        public FrmLlamador()
        {
            InitializeComponent();
        }
        public FrmLlamador(Centralita center):this()
        {
            this.llamada = center;
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void FranjaBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FrmLlamador_Load(object sender, EventArgs e)
        {

        }

        private void TxtDestino_TextChanged(object sender, EventArgs e)
        {
            if(txtDestino.Text.StartsWith("#"))
            {
                FranjaBox.Enabled = true;
            }else
            {
                FranjaBox.Enabled = false;
            }
        }

        private void Button13_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            float duracion = random.Next(1, 50);
            string mensaje = string.Empty;
            if(txtDestino.Text != "Nro Destino" && txtOrigen.Text != "Nro Origen")
            {
                if (txtDestino.Text.StartsWith("#"))
                {
                    FranjaBox.DataSource = Enum.GetValues(typeof(Provincial.Franja));
                    Provincial.Franja franja;
                    Enum.TryParse(FranjaBox.SelectedValue.ToString(), out franja);
                    Provincial aux = new Provincial(txtOrigen.Text, franja, duracion, txtDestino.Text);

                }
                else
                {
                    FranjaBox.Enabled = false;
                    float costo =(float)((random.Next(50,56))/100);
                    Local aux = new Local(txtOrigen.Text, duracion, txtDestino.Text, costo);
                }
                llamada += aux;
                mensaje = "Llamada creada exitosamente!";
                BtnLimpiar_Click(sender, e);
            }
            else
            {
                mensaje = "Debe cargar numero origen y destino";
            }
            MessageBox.Show(mensaje);
            

        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Form aux = new Central(llamada);
            this.Close();
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            txtDestino.Text = "Nro Destino";
            txtOrigen.Text = "Nro Origen";
        }
        #region PanelNumerico
        private void Button10_Click(object sender, EventArgs e)
        {
            LimpiarOConcatenar("*");
        }

        private void Button11_Click(object sender, EventArgs e)
        {
            LimpiarOConcatenar("0");
        }
        private void Button12_Click(object sender, EventArgs e)
        {
            LimpiarOConcatenar("#");
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            LimpiarOConcatenar("1");
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            LimpiarOConcatenar("2");
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            LimpiarOConcatenar("3");
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            LimpiarOConcatenar("4");
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            LimpiarOConcatenar("5");
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            LimpiarOConcatenar("6");
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            LimpiarOConcatenar("7");
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            LimpiarOConcatenar("8");
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            LimpiarOConcatenar("9");
        }
        #endregion  
        private void LimpiarOConcatenar(string valor)
        {
            if (txtFoco.Text == "Nro Destino" || txtFoco.Text == "Nro Origen")
            {
                txtFoco.Text = valor;
            }
            else
            {
                txtFoco.Text += valor;
            }
        }

        private void TxtOrigen_Click(object sender, EventArgs e)
        {
            txtFoco = txtOrigen;
        }

        private void TxtDestino_Click(object sender, EventArgs e)
        {
            txtFoco = txtDestino;
        }
    }
}
