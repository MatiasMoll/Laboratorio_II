namespace CentralitaForm
{
    partial class Central
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
            this.btnNewLlamada = new System.Windows.Forms.Button();
            this.btnTotalFac = new System.Windows.Forms.Button();
            this.btnLocalFac = new System.Windows.Forms.Button();
            this.btnProvFac = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnNewLlamada
            // 
            this.btnNewLlamada.Location = new System.Drawing.Point(12, 12);
            this.btnNewLlamada.Name = "btnNewLlamada";
            this.btnNewLlamada.Size = new System.Drawing.Size(232, 68);
            this.btnNewLlamada.TabIndex = 0;
            this.btnNewLlamada.Text = "Generar Llamada";
            this.btnNewLlamada.UseVisualStyleBackColor = true;
            this.btnNewLlamada.Click += new System.EventHandler(this.BtnNewLlamada_Click);
            // 
            // btnTotalFac
            // 
            this.btnTotalFac.Location = new System.Drawing.Point(13, 87);
            this.btnTotalFac.Name = "btnTotalFac";
            this.btnTotalFac.Size = new System.Drawing.Size(232, 68);
            this.btnTotalFac.TabIndex = 1;
            this.btnTotalFac.Text = "Facturacion Total";
            this.btnTotalFac.UseVisualStyleBackColor = true;
            this.btnTotalFac.Click += new System.EventHandler(this.BtnTotalFac_Click);
            // 
            // btnLocalFac
            // 
            this.btnLocalFac.Location = new System.Drawing.Point(12, 161);
            this.btnLocalFac.Name = "btnLocalFac";
            this.btnLocalFac.Size = new System.Drawing.Size(232, 68);
            this.btnLocalFac.TabIndex = 2;
            this.btnLocalFac.Text = "Facturacion Local";
            this.btnLocalFac.UseVisualStyleBackColor = true;
            this.btnLocalFac.Click += new System.EventHandler(this.BtnLocalFac_Click);
            // 
            // btnProvFac
            // 
            this.btnProvFac.Location = new System.Drawing.Point(13, 235);
            this.btnProvFac.Name = "btnProvFac";
            this.btnProvFac.Size = new System.Drawing.Size(232, 68);
            this.btnProvFac.TabIndex = 3;
            this.btnProvFac.Text = "Facturacion Provincial";
            this.btnProvFac.UseVisualStyleBackColor = true;
            this.btnProvFac.Click += new System.EventHandler(this.BtnProvFac_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(12, 309);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(232, 68);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Salir";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // Central
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(256, 385);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnProvFac);
            this.Controls.Add(this.btnLocalFac);
            this.Controls.Add(this.btnTotalFac);
            this.Controls.Add(this.btnNewLlamada);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Central";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Central Telefonica";
            this.Load += new System.EventHandler(this.Central_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNewLlamada;
        private System.Windows.Forms.Button btnTotalFac;
        private System.Windows.Forms.Button btnLocalFac;
        private System.Windows.Forms.Button btnProvFac;
        private System.Windows.Forms.Button btnExit;
    }
}

