namespace FrmCantina
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnCerveza = new System.Windows.Forms.RadioButton();
            this.btnAgua = new System.Windows.Forms.RadioButton();
            this.numCapacidad = new System.Windows.Forms.NumericUpDown();
            this.numContenido = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Capacidad = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.barra1 = new ControlCantina.Barra();
            ((System.ComponentModel.ISupportInitialize)(this.numCapacidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numContenido)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCerveza
            // 
            this.btnCerveza.AutoSize = true;
            this.btnCerveza.Checked = true;
            this.btnCerveza.Location = new System.Drawing.Point(15, 471);
            this.btnCerveza.Name = "btnCerveza";
            this.btnCerveza.Size = new System.Drawing.Size(64, 17);
            this.btnCerveza.TabIndex = 0;
            this.btnCerveza.TabStop = true;
            this.btnCerveza.Text = "Cerveza";
            this.btnCerveza.UseVisualStyleBackColor = true;
            // 
            // btnAgua
            // 
            this.btnAgua.AutoSize = true;
            this.btnAgua.Location = new System.Drawing.Point(15, 494);
            this.btnAgua.Name = "btnAgua";
            this.btnAgua.Size = new System.Drawing.Size(50, 17);
            this.btnAgua.TabIndex = 1;
            this.btnAgua.TabStop = true;
            this.btnAgua.Text = "Agua";
            this.btnAgua.UseVisualStyleBackColor = true;
            // 
            // numCapacidad
            // 
            this.numCapacidad.Location = new System.Drawing.Point(131, 513);
            this.numCapacidad.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.numCapacidad.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numCapacidad.Name = "numCapacidad";
            this.numCapacidad.Size = new System.Drawing.Size(120, 20);
            this.numCapacidad.TabIndex = 2;
            this.numCapacidad.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // numContenido
            // 
            this.numContenido.Location = new System.Drawing.Point(317, 513);
            this.numContenido.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.numContenido.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numContenido.Name = "numContenido";
            this.numContenido.Size = new System.Drawing.Size(120, 20);
            this.numContenido.TabIndex = 3;
            this.numContenido.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(128, 455);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Marca";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(317, 454);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Botella Tipo";
            // 
            // Capacidad
            // 
            this.Capacidad.AllowDrop = true;
            this.Capacidad.AutoSize = true;
            this.Capacidad.Location = new System.Drawing.Point(128, 496);
            this.Capacidad.Name = "Capacidad";
            this.Capacidad.Size = new System.Drawing.Size(58, 13);
            this.Capacidad.TabIndex = 6;
            this.Capacidad.Text = "Capacidad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(317, 494);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Contenido";
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(131, 471);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(100, 20);
            this.txtMarca.TabIndex = 8;
            // 
            // cmbTipo
            // 
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Location = new System.Drawing.Point(320, 470);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(121, 21);
            this.cmbTipo.TabIndex = 9;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(458, 467);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(126, 66);
            this.btnAgregar.TabIndex = 10;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // barra1
            // 
            this.barra1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("barra1.BackgroundImage")));
            this.barra1.Location = new System.Drawing.Point(15, 12);
            this.barra1.Name = "barra1";
            this.barra1.Size = new System.Drawing.Size(551, 360);
            this.barra1.TabIndex = 11;
            this.barra1.Load += new System.EventHandler(this.Barra1_Load);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 545);
            this.Controls.Add(this.barra1);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.cmbTipo);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Capacidad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numContenido);
            this.Controls.Add(this.numCapacidad);
            this.Controls.Add(this.btnAgua);
            this.Controls.Add(this.btnCerveza);
            this.Name = "Form1";
            this.Text = "Parcial Matias Moll";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numCapacidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numContenido)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton btnCerveza;
        private System.Windows.Forms.RadioButton btnAgua;
        private System.Windows.Forms.NumericUpDown numCapacidad;
        private System.Windows.Forms.NumericUpDown numContenido;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Capacidad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.Button btnAgregar;
        private ControlCantina.Barra barra1;
    }
}

