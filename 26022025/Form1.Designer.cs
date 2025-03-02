namespace _26022025
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
            this.tmr1 = new System.Windows.Forms.Timer(this.components);
            this.btnDesplazar = new System.Windows.Forms.Button();
            this.pic1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).BeginInit();
            this.SuspendLayout();
            // 
            // tmr1
            // 
            this.tmr1.Interval = 10;
            this.tmr1.Tick += new System.EventHandler(this.tmr1_Tick);
            // 
            // btnDesplazar
            // 
            this.btnDesplazar.Location = new System.Drawing.Point(287, 365);
            this.btnDesplazar.Name = "btnDesplazar";
            this.btnDesplazar.Size = new System.Drawing.Size(163, 54);
            this.btnDesplazar.TabIndex = 1;
            this.btnDesplazar.Text = "Desplazar";
            this.btnDesplazar.UseVisualStyleBackColor = true;
            this.btnDesplazar.Click += new System.EventHandler(this.btnDesplazar_Click);
            // 
            // pic1
            // 
            this.pic1.Image = ((System.Drawing.Image)(resources.GetObject("pic1.Image")));
            this.pic1.Location = new System.Drawing.Point(12, 40);
            this.pic1.Name = "pic1";
            this.pic1.Size = new System.Drawing.Size(332, 259);
            this.pic1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic1.TabIndex = 0;
            this.pic1.TabStop = false;
            this.pic1.Click += new System.EventHandler(this.pic1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDesplazar);
            this.Controls.Add(this.pic1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer tmr1;
        private System.Windows.Forms.Button btnDesplazar;
        private System.Windows.Forms.PictureBox pic1;
    }
}

