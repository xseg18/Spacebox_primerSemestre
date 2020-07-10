namespace Spacebox_XSEG
{
    partial class Simulacion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Simulacion));
            this.Tablero_Principal = new System.Windows.Forms.PictureBox();
            this.PanelInformación = new System.Windows.Forms.GroupBox();
            this.TB_puntuacionmayor = new System.Windows.Forms.Label();
            this.TB_punteo = new System.Windows.Forms.Label();
            this.TB_Espacios = new System.Windows.Forms.Label();
            this.TB_movimientos = new System.Windows.Forms.Label();
            this.TB_nave = new System.Windows.Forms.Label();
            this.B_Reinicio = new System.Windows.Forms.Button();
            this.PB_cargando = new System.Windows.Forms.ProgressBar();
            this.PB_csimulacion = new System.Windows.Forms.PictureBox();
            this.T_cargando = new System.Windows.Forms.Timer(this.components);
            this.WinnerLoser_PB = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Tablero_Principal)).BeginInit();
            this.PanelInformación.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB_csimulacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WinnerLoser_PB)).BeginInit();
            this.SuspendLayout();
            // 
            // Tablero_Principal
            // 
            this.Tablero_Principal.BackColor = System.Drawing.Color.Transparent;
            this.Tablero_Principal.Location = new System.Drawing.Point(4, 3);
            this.Tablero_Principal.Name = "Tablero_Principal";
            this.Tablero_Principal.Size = new System.Drawing.Size(986, 820);
            this.Tablero_Principal.TabIndex = 0;
            this.Tablero_Principal.TabStop = false;
            this.Tablero_Principal.Visible = false;
            // 
            // PanelInformación
            // 
            this.PanelInformación.BackColor = System.Drawing.Color.Transparent;
            this.PanelInformación.BackgroundImage = global::Spacebox_XSEG.Properties.Resources.panel_info_oscuro;
            this.PanelInformación.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PanelInformación.Controls.Add(this.TB_puntuacionmayor);
            this.PanelInformación.Controls.Add(this.TB_punteo);
            this.PanelInformación.Controls.Add(this.TB_Espacios);
            this.PanelInformación.Controls.Add(this.TB_movimientos);
            this.PanelInformación.Controls.Add(this.TB_nave);
            this.PanelInformación.Location = new System.Drawing.Point(1013, 125);
            this.PanelInformación.Name = "PanelInformación";
            this.PanelInformación.Size = new System.Drawing.Size(342, 458);
            this.PanelInformación.TabIndex = 1;
            this.PanelInformación.TabStop = false;
            this.PanelInformación.Visible = false;
            // 
            // TB_puntuacionmayor
            // 
            this.TB_puntuacionmayor.AutoSize = true;
            this.TB_puntuacionmayor.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_puntuacionmayor.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.TB_puntuacionmayor.Location = new System.Drawing.Point(215, 401);
            this.TB_puntuacionmayor.Name = "TB_puntuacionmayor";
            this.TB_puntuacionmayor.Size = new System.Drawing.Size(0, 23);
            this.TB_puntuacionmayor.TabIndex = 4;
            // 
            // TB_punteo
            // 
            this.TB_punteo.AutoSize = true;
            this.TB_punteo.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_punteo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.TB_punteo.Location = new System.Drawing.Point(215, 313);
            this.TB_punteo.Name = "TB_punteo";
            this.TB_punteo.Size = new System.Drawing.Size(0, 23);
            this.TB_punteo.TabIndex = 3;
            // 
            // TB_Espacios
            // 
            this.TB_Espacios.AutoSize = true;
            this.TB_Espacios.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_Espacios.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.TB_Espacios.Location = new System.Drawing.Point(215, 222);
            this.TB_Espacios.Name = "TB_Espacios";
            this.TB_Espacios.Size = new System.Drawing.Size(0, 23);
            this.TB_Espacios.TabIndex = 2;
            // 
            // TB_movimientos
            // 
            this.TB_movimientos.AutoSize = true;
            this.TB_movimientos.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_movimientos.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.TB_movimientos.Location = new System.Drawing.Point(215, 134);
            this.TB_movimientos.Name = "TB_movimientos";
            this.TB_movimientos.Size = new System.Drawing.Size(0, 23);
            this.TB_movimientos.TabIndex = 1;
            // 
            // TB_nave
            // 
            this.TB_nave.AutoSize = true;
            this.TB_nave.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_nave.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.TB_nave.Location = new System.Drawing.Point(193, 36);
            this.TB_nave.Name = "TB_nave";
            this.TB_nave.Size = new System.Drawing.Size(0, 23);
            this.TB_nave.TabIndex = 0;
            // 
            // B_Reinicio
            // 
            this.B_Reinicio.BackColor = System.Drawing.Color.Transparent;
            this.B_Reinicio.BackgroundImage = global::Spacebox_XSEG.Properties.Resources.reiniciar;
            this.B_Reinicio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.B_Reinicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B_Reinicio.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.B_Reinicio.Location = new System.Drawing.Point(1047, 705);
            this.B_Reinicio.Name = "B_Reinicio";
            this.B_Reinicio.Size = new System.Drawing.Size(297, 62);
            this.B_Reinicio.TabIndex = 2;
            this.B_Reinicio.UseVisualStyleBackColor = false;
            this.B_Reinicio.Visible = false;
            this.B_Reinicio.Click += new System.EventHandler(this.B_Reinicio_Click);
            // 
            // PB_cargando
            // 
            this.PB_cargando.Location = new System.Drawing.Point(74, 541);
            this.PB_cargando.Name = "PB_cargando";
            this.PB_cargando.Size = new System.Drawing.Size(1174, 64);
            this.PB_cargando.TabIndex = 3;
            // 
            // PB_csimulacion
            // 
            this.PB_csimulacion.BackColor = System.Drawing.Color.Transparent;
            this.PB_csimulacion.Location = new System.Drawing.Point(114, 464);
            this.PB_csimulacion.Name = "PB_csimulacion";
            this.PB_csimulacion.Size = new System.Drawing.Size(1114, 67);
            this.PB_csimulacion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PB_csimulacion.TabIndex = 4;
            this.PB_csimulacion.TabStop = false;
            // 
            // T_cargando
            // 
            this.T_cargando.Enabled = true;
            this.T_cargando.Tick += new System.EventHandler(this.T_cargando_Tick);
            // 
            // WinnerLoser_PB
            // 
            this.WinnerLoser_PB.BackColor = System.Drawing.Color.Transparent;
            this.WinnerLoser_PB.Location = new System.Drawing.Point(74, 3);
            this.WinnerLoser_PB.Name = "WinnerLoser_PB";
            this.WinnerLoser_PB.Size = new System.Drawing.Size(1195, 821);
            this.WinnerLoser_PB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.WinnerLoser_PB.TabIndex = 5;
            this.WinnerLoser_PB.TabStop = false;
            this.WinnerLoser_PB.Visible = false;
            this.WinnerLoser_PB.Click += new System.EventHandler(this.WinnerLoser_PB_Click);
            // 
            // Simulacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Spacebox_XSEG.Properties.Resources.photo_1568489601916_b6dd81cbc0be;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1387, 831);
            this.Controls.Add(this.WinnerLoser_PB);
            this.Controls.Add(this.PB_csimulacion);
            this.Controls.Add(this.PB_cargando);
            this.Controls.Add(this.B_Reinicio);
            this.Controls.Add(this.PanelInformación);
            this.Controls.Add(this.Tablero_Principal);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Simulacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SpaceBox-Simulacion";
            this.Load += new System.EventHandler(this.Simulacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Tablero_Principal)).EndInit();
            this.PanelInformación.ResumeLayout(false);
            this.PanelInformación.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB_csimulacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WinnerLoser_PB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Tablero_Principal;
        private System.Windows.Forms.GroupBox PanelInformación;
        private System.Windows.Forms.Button B_Reinicio;
        private System.Windows.Forms.Label TB_puntuacionmayor;
        private System.Windows.Forms.Label TB_punteo;
        private System.Windows.Forms.Label TB_Espacios;
        private System.Windows.Forms.Label TB_movimientos;
        private System.Windows.Forms.Label TB_nave;
        private System.Windows.Forms.ProgressBar PB_cargando;
        private System.Windows.Forms.PictureBox PB_csimulacion;
        private System.Windows.Forms.Timer T_cargando;
        private System.Windows.Forms.PictureBox WinnerLoser_PB;
    }
}