namespace Ejercicio_XXIII
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtEuro = new System.Windows.Forms.TextBox();
            this.TxtDolar = new System.Windows.Forms.TextBox();
            this.TxtPeso = new System.Windows.Forms.TextBox();
            this.Euros = new System.Windows.Forms.Button();
            this.Dolars = new System.Windows.Forms.Button();
            this.Pesos = new System.Windows.Forms.Button();
            this.cotizacion = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.ResEuroEuro = new System.Windows.Forms.MaskedTextBox();
            this.ResEuroDolar = new System.Windows.Forms.MaskedTextBox();
            this.ResEuroPeso = new System.Windows.Forms.MaskedTextBox();
            this.ResDolarEuro = new System.Windows.Forms.MaskedTextBox();
            this.ResDolarDolar = new System.Windows.Forms.MaskedTextBox();
            this.ResDolarPeso = new System.Windows.Forms.MaskedTextBox();
            this.ResPesoEuro = new System.Windows.Forms.MaskedTextBox();
            this.ResPesoDolar = new System.Windows.Forms.MaskedTextBox();
            this.ResPesoPeso = new System.Windows.Forms.MaskedTextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(103, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cotizacion";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Euro";
            this.label2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Dolar";
            this.label3.Click += new System.EventHandler(this.Label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Peso";
            // 
            // TxtEuro
            // 
            this.TxtEuro.Location = new System.Drawing.Point(108, 66);
            this.TxtEuro.Name = "TxtEuro";
            this.TxtEuro.Size = new System.Drawing.Size(100, 20);
            this.TxtEuro.TabIndex = 4;
            // 
            // TxtDolar
            // 
            this.TxtDolar.Location = new System.Drawing.Point(108, 128);
            this.TxtDolar.Name = "TxtDolar";
            this.TxtDolar.Size = new System.Drawing.Size(100, 20);
            this.TxtDolar.TabIndex = 5;
            this.TxtDolar.TextChanged += new System.EventHandler(this.TextBox2_TextChanged);
            // 
            // TxtPeso
            // 
            this.TxtPeso.Location = new System.Drawing.Point(108, 187);
            this.TxtPeso.Name = "TxtPeso";
            this.TxtPeso.Size = new System.Drawing.Size(100, 20);
            this.TxtPeso.TabIndex = 6;
            // 
            // Euros
            // 
            this.Euros.Location = new System.Drawing.Point(239, 66);
            this.Euros.Name = "Euros";
            this.Euros.Size = new System.Drawing.Size(75, 23);
            this.Euros.TabIndex = 16;
            this.Euros.Text = "->";
            this.Euros.UseVisualStyleBackColor = true;
            this.Euros.Click += new System.EventHandler(this.Euros_Click);
            // 
            // Dolars
            // 
            this.Dolars.Location = new System.Drawing.Point(239, 125);
            this.Dolars.Name = "Dolars";
            this.Dolars.Size = new System.Drawing.Size(75, 23);
            this.Dolars.TabIndex = 17;
            this.Dolars.Text = "->";
            this.Dolars.UseVisualStyleBackColor = true;
            this.Dolars.Click += new System.EventHandler(this.Dolars_Click);
            // 
            // Pesos
            // 
            this.Pesos.Location = new System.Drawing.Point(239, 187);
            this.Pesos.Name = "Pesos";
            this.Pesos.Size = new System.Drawing.Size(75, 23);
            this.Pesos.TabIndex = 18;
            this.Pesos.Text = "->";
            this.Pesos.UseVisualStyleBackColor = true;
            this.Pesos.Click += new System.EventHandler(this.Pesos_Click);
            // 
            // cotizacion
            // 
            this.cotizacion.ForeColor = System.Drawing.Color.Black;
            this.cotizacion.ImageIndex = 0;
            this.cotizacion.ImageList = this.imageList1;
            this.cotizacion.Location = new System.Drawing.Point(239, 9);
            this.cotizacion.Name = "cotizacion";
            this.cotizacion.Size = new System.Drawing.Size(75, 23);
            this.cotizacion.TabIndex = 19;
            this.cotizacion.UseVisualStyleBackColor = true;
            this.cotizacion.Click += new System.EventHandler(this.Cotizacion_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Koala.jpg");
            this.imageList1.Images.SetKeyName(1, "Penguins.jpg");
            // 
            // ResEuroEuro
            // 
            this.ResEuroEuro.Location = new System.Drawing.Point(375, 68);
            this.ResEuroEuro.Mask = "99.99";
            this.ResEuroEuro.Name = "ResEuroEuro";
            this.ResEuroEuro.Size = new System.Drawing.Size(100, 20);
            this.ResEuroEuro.TabIndex = 23;
            this.ResEuroEuro.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.MaskedTextBox1_MaskInputRejected);
            // 
            // ResEuroDolar
            // 
            this.ResEuroDolar.Location = new System.Drawing.Point(511, 69);
            this.ResEuroDolar.Mask = "99.99";
            this.ResEuroDolar.Name = "ResEuroDolar";
            this.ResEuroDolar.Size = new System.Drawing.Size(100, 20);
            this.ResEuroDolar.TabIndex = 24;
            // 
            // ResEuroPeso
            // 
            this.ResEuroPeso.Location = new System.Drawing.Point(649, 69);
            this.ResEuroPeso.Mask = "99.99";
            this.ResEuroPeso.Name = "ResEuroPeso";
            this.ResEuroPeso.Size = new System.Drawing.Size(100, 20);
            this.ResEuroPeso.TabIndex = 25;
            this.ResEuroPeso.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.MaskedTextBox3_MaskInputRejected);
            // 
            // ResDolarEuro
            // 
            this.ResDolarEuro.Location = new System.Drawing.Point(375, 127);
            this.ResDolarEuro.Mask = "99.99";
            this.ResDolarEuro.Name = "ResDolarEuro";
            this.ResDolarEuro.Size = new System.Drawing.Size(100, 20);
            this.ResDolarEuro.TabIndex = 26;
            // 
            // ResDolarDolar
            // 
            this.ResDolarDolar.Location = new System.Drawing.Point(511, 127);
            this.ResDolarDolar.Mask = "99.99";
            this.ResDolarDolar.Name = "ResDolarDolar";
            this.ResDolarDolar.Size = new System.Drawing.Size(100, 20);
            this.ResDolarDolar.TabIndex = 27;
            // 
            // ResDolarPeso
            // 
            this.ResDolarPeso.Location = new System.Drawing.Point(649, 127);
            this.ResDolarPeso.Mask = "99.99";
            this.ResDolarPeso.Name = "ResDolarPeso";
            this.ResDolarPeso.Size = new System.Drawing.Size(100, 20);
            this.ResDolarPeso.TabIndex = 28;
            // 
            // ResPesoEuro
            // 
            this.ResPesoEuro.Location = new System.Drawing.Point(375, 192);
            this.ResPesoEuro.Mask = "99.99";
            this.ResPesoEuro.Name = "ResPesoEuro";
            this.ResPesoEuro.Size = new System.Drawing.Size(100, 20);
            this.ResPesoEuro.TabIndex = 29;
            // 
            // ResPesoDolar
            // 
            this.ResPesoDolar.Location = new System.Drawing.Point(511, 193);
            this.ResPesoDolar.Mask = "99.99";
            this.ResPesoDolar.Name = "ResPesoDolar";
            this.ResPesoDolar.Size = new System.Drawing.Size(100, 20);
            this.ResPesoDolar.TabIndex = 30;
            // 
            // ResPesoPeso
            // 
            this.ResPesoPeso.Location = new System.Drawing.Point(649, 192);
            this.ResPesoPeso.Mask = "99.99";
            this.ResPesoPeso.Name = "ResPesoPeso";
            this.ResPesoPeso.Size = new System.Drawing.Size(100, 20);
            this.ResPesoPeso.TabIndex = 31;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(375, 11);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 32;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(511, 13);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 33;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(649, 13);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 34;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(388, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 25);
            this.label5.TabIndex = 35;
            this.label5.Text = "Euro";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(527, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 25);
            this.label6.TabIndex = 36;
            this.label6.Text = "Dolar";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(665, 40);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 25);
            this.label7.TabIndex = 37;
            this.label7.Text = "Peso";
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(784, 295);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.ResPesoPeso);
            this.Controls.Add(this.ResPesoDolar);
            this.Controls.Add(this.ResPesoEuro);
            this.Controls.Add(this.ResDolarPeso);
            this.Controls.Add(this.ResDolarDolar);
            this.Controls.Add(this.ResDolarEuro);
            this.Controls.Add(this.ResEuroPeso);
            this.Controls.Add(this.ResEuroDolar);
            this.Controls.Add(this.ResEuroEuro);
            this.Controls.Add(this.cotizacion);
            this.Controls.Add(this.Pesos);
            this.Controls.Add(this.Dolars);
            this.Controls.Add(this.Euros);
            this.Controls.Add(this.TxtPeso);
            this.Controls.Add(this.TxtDolar);
            this.Controls.Add(this.TxtEuro);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cotizacion";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtEuro;
        private System.Windows.Forms.TextBox TxtDolar;
        private System.Windows.Forms.TextBox TxtPeso;
        private System.Windows.Forms.Button Euros;
        private System.Windows.Forms.Button Dolars;
        private System.Windows.Forms.Button Pesos;
        private System.Windows.Forms.Button cotizacion;
        private System.Windows.Forms.MaskedTextBox ResEuroEuro;
        private System.Windows.Forms.MaskedTextBox ResEuroDolar;
        private System.Windows.Forms.MaskedTextBox ResEuroPeso;
        private System.Windows.Forms.MaskedTextBox ResDolarEuro;
        private System.Windows.Forms.MaskedTextBox ResDolarDolar;
        private System.Windows.Forms.MaskedTextBox ResDolarPeso;
        private System.Windows.Forms.MaskedTextBox ResPesoEuro;
        private System.Windows.Forms.MaskedTextBox ResPesoDolar;
        private System.Windows.Forms.MaskedTextBox ResPesoPeso;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}

