using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Examne;

namespace ControlCantina
{
    public partial class Barra : UserControl
    {
        private Cantina cantina;
        private int offset;
        private const int CORRIMIENTO_OFFSET = 56;

        public Barra()
        {
            InitializeComponent();
            offset = 10;
        }

        public Cantina SetCantina {
            set
            {
                this.cantina = value;
                /*this.cantina.Botellas.Add(new Cerveza(2000, "", Botella.Tipo.Vidrio, 2000));
                this.cantina.Botellas.Add(new Agua(2000, "", 2000));
                this.cantina.Botellas.Add(new Cerveza(2000, "", Botella.Tipo.Plastico, 2000));*/
                this.DibujarBotellas();
            }
        }

        public void AgregarBotella(Botella b)
        {
            if (this.cantina + b)
            {
                this.BotellaEnBarra(b);
            }
        }

        public void DibujarBotellas()
        {
            foreach (Botella item in this.cantina.Botellas)
            {
                this.BotellaEnBarra(item);
            }
        }

        private void BotellaEnBarra(Botella item)
        {
            string src;

            PictureBox pb = new PictureBox();
            if (item is Agua)
            {
                src = "bottle.png";
            }
            else
            {
                Botella.Tipo tipo = ((Cerveza)item);
                switch (tipo)
                {
                    case Botella.Tipo.Plastico:
                        src = "bottle-2.png";
                        break;
                    default:
                        src = "bottle-3.png";
                        break;
                }
            }
            pb.Image = System.Drawing.Image.FromFile(src);
            pb.Location = new System.Drawing.Point(offset, 225);
            pb.Size = new System.Drawing.Size(64, 64);
            pb.BackColor = Color.Transparent;
            pb.Click += this.ServirCopa;
            pb.Tag = item;

            this.Controls.Add(pb);
            offset += CORRIMIENTO_OFFSET;
        }

        private void ServirCopa(object sender, EventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            Botella botella = (Botella)pb.Tag;
            // Muevo la botella a ser servida
            Point ubicacion = pb.Location;
            pb.Location = new System.Drawing.Point(125, 125);

            int cantidadServida = botella.ServirMedida();
            if(cantidadServida == 0)
            {
                MessageBox.Show("No queda mas Liquido!");
            }
            MessageBox.Show(string.Format("SIRVIENDO! {1}ml\n{0}", botella.ToString(), cantidadServida), "Cantinero", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            pb.Location = ubicacion;
        }
    }
}
