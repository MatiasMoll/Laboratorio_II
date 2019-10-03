using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComiqueriaLogic;

namespace ComiqueriaApp
{
    public partial class VentasForm : Form
    {
        Comiqueria comiqueria = new Comiqueria();
        Producto producto;
        public VentasForm()
        {
            InitializeComponent();
        }
        public VentasForm(Comiqueria comiqueria,Producto p):this()
        {
            this.comiqueria = comiqueria;
            this.producto = p;
        }

      

        private void VentasForm_Load(object sender, EventArgs e)
        {
            lblDescripcion.Text = producto.Descripcion;
            lblPrecioFinal.Text += producto.Precio.ToString();
        }

  
        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnVender_Click(object sender, EventArgs e)
        {
            if((int)(numericUpDownCantidad.Value) <= producto.Stock)
            {
                comiqueria.Vender(producto, (int)numericUpDownCantidad.Value);
                this.DialogResult = DialogResult.OK;
                MessageBox.Show("Venta creada exitosamente!");
                this.Close();
            }else
            {
                MessageBox.Show("Ha superado es stock disponible", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void NumericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            double aux = (double)numericUpDownCantidad.Value;
            string auxString = "Precio Final: ";
            aux = aux * producto.Precio;
            lblPrecioFinal.Text = auxString + aux;


        }
    }
}
