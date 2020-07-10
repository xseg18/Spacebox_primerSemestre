using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Spacebox_XSEG
{
    public partial class Instrucciones : Form
    {
        public Instrucciones()
        {
            InitializeComponent();
        }

        private void PB_Regreso_Click(object sender, EventArgs e)
        {
            this.Close();
            Inicio regreso = new Inicio();
            regreso.Show();
        }

        int contador;
        private void B_Siguiente_Click(object sender, EventArgs e)
        {
            if (contador <= 7)
            {
                contador++;
                PanelInstrucciones.Image = (Image)Properties.Resources.ResourceManager.GetObject("instrucciones2" + contador);
            }
            else
            {
                PanelInstrucciones.Visible = false;
                estaslisto_PB.Visible = true;
                B_IngresoInfo.Visible = true;
            }
        }

        private void Instrucciones_Load(object sender, EventArgs e)
        {
            contador = 0;
        }

        private void B_IngresoInfo_Click(object sender, EventArgs e)
        {
            Ingreso_Info cambio = new Ingreso_Info();
            cambio.Show();
            this.Close();
        }
    }
}
