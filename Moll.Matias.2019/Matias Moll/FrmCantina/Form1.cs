using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Examne;
using ControlCantina;

namespace FrmCantina
{
    public partial class Form1 : Form
    {
        public Barra barra = new Barra();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbTipo.DataSource = Enum.GetValues(typeof(Botella.Tipo));
            this.barra.SetCantina = Cantina.GetCantina(10);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            int capacidadInt = (int)numCapacidad.Value;
            int contenidoInt = (int)numContenido.Value;
            Botella botella;
            string marca = txtMarca.Text;
            if(btnCerveza.Checked)
            {
                Botella.Tipo tipo;
                Enum.TryParse<Botella.Tipo>(cmbTipo.SelectedValue.ToString(), out tipo);
                botella = new Cerveza(capacidadInt, marca, tipo,contenidoInt);
                
            }else 
            {
                botella = new Agua(capacidadInt, marca, contenidoInt);
            }
            if (botella is Agua)
            {
                barra.AgregarBotella((Agua)botella);
            }else if (botella is Cerveza)
            {
                barra.AgregarBotella((Cerveza)botella);
            }
        }

        private void barra1_Load(object sender, EventArgs e)
        {

        }
    }
}
