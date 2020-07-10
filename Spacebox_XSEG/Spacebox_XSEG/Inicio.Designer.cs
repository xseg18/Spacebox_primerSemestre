namespace Spacebox_XSEG
{
    partial class Inicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.B_IngresoInfo = new System.Windows.Forms.Button();
            this.B_Instrucciones = new System.Windows.Forms.Button();
            this.B_Salir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Spacebox_XSEG.Properties.Resources.logo_2;
            this.pictureBox1.Location = new System.Drawing.Point(60, 36);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(598, 312);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // B_IngresoInfo
            // 
            this.B_IngresoInfo.BackColor = System.Drawing.Color.Transparent;
            this.B_IngresoInfo.BackgroundImage = global::Spacebox_XSEG.Properties.Resources.ingresar;
            this.B_IngresoInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.B_IngresoInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B_IngresoInfo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.B_IngresoInfo.Location = new System.Drawing.Point(177, 368);
            this.B_IngresoInfo.Name = "B_IngresoInfo";
            this.B_IngresoInfo.Size = new System.Drawing.Size(349, 58);
            this.B_IngresoInfo.TabIndex = 1;
            this.B_IngresoInfo.UseVisualStyleBackColor = false;
            this.B_IngresoInfo.Click += new System.EventHandler(this.B_IngresoInfo_Click);
            // 
            // B_Instrucciones
            // 
            this.B_Instrucciones.BackColor = System.Drawing.Color.Transparent;
            this.B_Instrucciones.BackgroundImage = global::Spacebox_XSEG.Properties.Resources.instrucciones;
            this.B_Instrucciones.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.B_Instrucciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B_Instrucciones.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.B_Instrucciones.Location = new System.Drawing.Point(136, 444);
            this.B_Instrucciones.Name = "B_Instrucciones";
            this.B_Instrucciones.Size = new System.Drawing.Size(435, 58);
            this.B_Instrucciones.TabIndex = 2;
            this.B_Instrucciones.UseVisualStyleBackColor = false;
            this.B_Instrucciones.Click += new System.EventHandler(this.B_Instrucciones_Click);
            // 
            // B_Salir
            // 
            this.B_Salir.BackColor = System.Drawing.Color.Transparent;
            this.B_Salir.BackgroundImage = global::Spacebox_XSEG.Properties.Resources.salir;
            this.B_Salir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.B_Salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B_Salir.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.B_Salir.Location = new System.Drawing.Point(228, 520);
            this.B_Salir.Name = "B_Salir";
            this.B_Salir.Size = new System.Drawing.Size(235, 58);
            this.B_Salir.TabIndex = 3;
            this.B_Salir.UseVisualStyleBackColor = false;
            this.B_Salir.Click += new System.EventHandler(this.B_Salir_Click);
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Spacebox_XSEG.Properties.Resources.photo_1568489601916_b6dd81cbc0be;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(738, 602);
            this.Controls.Add(this.B_Salir);
            this.Controls.Add(this.B_Instrucciones);
            this.Controls.Add(this.B_IngresoInfo);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Inicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Spacebox";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button B_IngresoInfo;
        private System.Windows.Forms.Button B_Instrucciones;
        private System.Windows.Forms.Button B_Salir;
    }
}

