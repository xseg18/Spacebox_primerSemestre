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
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void B_IngresoInfo_Click(object sender, EventArgs e)
        {
            Ingreso_Info cambio = new Ingreso_Info();
            cambio.Show();
            this.Close();
        }

        private void B_Instrucciones_Click(object sender, EventArgs e)
        {
            Instrucciones cambio = new Instrucciones();
            cambio.Show();
            this.Close();
        }

        private void B_Salir_Click(object sender, EventArgs e)
        {
            string mensaje = "¿Seguro que desea salir?";
            string nombre = "Salir";
            MessageBoxButtons botones = MessageBoxButtons.YesNo;
            DialogResult result;
            result = MessageBox.Show(mensaje, nombre, botones);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                Application.ExitThread();
            }
        }
    }
}
