namespace Estadistica
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
            this.lblserie = new System.Windows.Forms.Label();
            this.txtserie = new System.Windows.Forms.TextBox();
            this.lblrespuesta = new System.Windows.Forms.Label();
            this.btnmediaAritmetica = new System.Windows.Forms.Button();
            this.btnEstandar = new System.Windows.Forms.Button();
            this.btnTipica = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblserie
            // 
            this.lblserie.AutoSize = true;
            this.lblserie.Location = new System.Drawing.Point(28, 49);
            this.lblserie.Name = "lblserie";
            this.lblserie.Size = new System.Drawing.Size(29, 13);
            this.lblserie.TabIndex = 0;
            this.lblserie.Text = "serie";
            // 
            // txtserie
            // 
            this.txtserie.Location = new System.Drawing.Point(69, 49);
            this.txtserie.Name = "txtserie";
            this.txtserie.Size = new System.Drawing.Size(118, 20);
            this.txtserie.TabIndex = 1;
            // 
            // lblrespuesta
            // 
            this.lblrespuesta.AutoSize = true;
            this.lblrespuesta.Location = new System.Drawing.Point(28, 79);
            this.lblrespuesta.Name = "lblrespuesta";
            this.lblrespuesta.Size = new System.Drawing.Size(12, 13);
            this.lblrespuesta.TabIndex = 2;
            this.lblrespuesta.Text = "x";
            // 
            // btnmediaAritmetica
            // 
            this.btnmediaAritmetica.Location = new System.Drawing.Point(31, 121);
            this.btnmediaAritmetica.Name = "btnmediaAritmetica";
            this.btnmediaAritmetica.Size = new System.Drawing.Size(75, 23);
            this.btnmediaAritmetica.TabIndex = 3;
            this.btnmediaAritmetica.Text = "Calcular x";
            this.btnmediaAritmetica.UseVisualStyleBackColor = true;
            this.btnmediaAritmetica.Click += new System.EventHandler(this.btnmediaaritmetica_Click);
            // 
            // btnEstandar
            // 
            this.btnEstandar.Location = new System.Drawing.Point(127, 121);
            this.btnEstandar.Name = "btnEstandar";
            this.btnEstandar.Size = new System.Drawing.Size(99, 23);
            this.btnEstandar.TabIndex = 4;
            this.btnEstandar.Text = "Calcular Estandar";
            this.btnEstandar.UseVisualStyleBackColor = true;
            this.btnEstandar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnTipica
            // 
            this.btnTipica.Location = new System.Drawing.Point(255, 121);
            this.btnTipica.Name = "btnTipica";
            this.btnTipica.Size = new System.Drawing.Size(96, 23);
            this.btnTipica.TabIndex = 5;
            this.btnTipica.Text = "Calcular Tipica";
            this.btnTipica.UseVisualStyleBackColor = true;
            this.btnTipica.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 226);
            this.Controls.Add(this.btnTipica);
            this.Controls.Add(this.btnEstandar);
            this.Controls.Add(this.btnmediaAritmetica);
            this.Controls.Add(this.lblrespuesta);
            this.Controls.Add(this.txtserie);
            this.Controls.Add(this.lblserie);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblserie;
        private System.Windows.Forms.TextBox txtserie;
        private System.Windows.Forms.Label lblrespuesta;
        private System.Windows.Forms.Button btnmediaAritmetica;
        private System.Windows.Forms.Button btnEstandar;
        private System.Windows.Forms.Button btnTipica;
    }
}

