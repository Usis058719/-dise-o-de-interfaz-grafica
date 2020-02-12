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
            this.lblrespserie = new System.Windows.Forms.Label();
            this.btnmediaaritmetica = new System.Windows.Forms.Button();
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
            this.txtserie.Size = new System.Drawing.Size(303, 20);
            this.txtserie.TabIndex = 1;
            // 
            // lblrespserie
            // 
            this.lblrespserie.AutoSize = true;
            this.lblrespserie.Location = new System.Drawing.Point(28, 79);
            this.lblrespserie.Name = "lblrespserie";
            this.lblrespserie.Size = new System.Drawing.Size(12, 13);
            this.lblrespserie.TabIndex = 2;
            this.lblrespserie.Text = "x";
            // 
            // btnmediaaritmetica
            // 
            this.btnmediaaritmetica.Location = new System.Drawing.Point(31, 121);
            this.btnmediaaritmetica.Name = "btnmediaaritmetica";
            this.btnmediaaritmetica.Size = new System.Drawing.Size(75, 23);
            this.btnmediaaritmetica.TabIndex = 3;
            this.btnmediaaritmetica.Text = "Calcular x";
            this.btnmediaaritmetica.UseVisualStyleBackColor = true;
            this.btnmediaaritmetica.Click += new System.EventHandler(this.btnmediaaritmetica_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 226);
            this.Controls.Add(this.btnmediaaritmetica);
            this.Controls.Add(this.lblrespserie);
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
        private System.Windows.Forms.Label lblrespserie;
        private System.Windows.Forms.Button btnmediaaritmetica;
    }
}

