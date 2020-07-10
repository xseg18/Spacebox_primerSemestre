using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Spacebox_XSEG
{
    public partial class Ingreso_Info : Form
    {
        public Ingreso_Info()
        {
            InitializeComponent();
        }

        bool lleno = false, lleno2 = false;
        string nombre, apellido, texto;
        int lineas;

        private void PB_Regreso_Click(object sender, EventArgs e)
        {
            this.Close();
            Inicio regreso = new Inicio();
            regreso.Show();
        }

        private void Ingreso_Info_Load(object sender, EventArgs e)
        {

        }

        private void B_NewPiloto_Click_1(object sender, EventArgs e)
        {
            bool tryy = false;
            try
            {
                int n = Convert.ToInt32(T_Apellido.Text);
                int n2 = Convert.ToInt32(T_Nombre.Text);
                tryy = true;
            }
            catch (Exception)
            {
                nombre = T_Nombre.Text.ToUpper();
                apellido = T_Apellido.Text.ToUpper();
            }
            if (nombre == "" || apellido == "" || tryy == true || System.Text.RegularExpressions.Regex.IsMatch(nombre, "[],!#$%&[{}<>;_()|°¬`*+~¡¿?'-]") || System.Text.RegularExpressions.Regex.IsMatch(apellido, "[],!#$%&[{}<>;_()|°¬`*+~¡¿?'-]"))
            {
                string mensajes = "No se ha ingresado correctamente la información pedida. Por favor, intentelo de nuevo.";
                string nombres = "Error";
                MessageBoxButtons botoness = MessageBoxButtons.OK;
                DialogResult results;
                results = MessageBox.Show(mensajes, nombres, botoness);
                T_Nombre.Clear();
                T_Apellido.Clear();
            }
            else
            {
                lleno2 = true;
                B_NewPiloto.Enabled = false;
            }
        }


        private void B_IniciarSimulación_Click(object sender, EventArgs e)
        {
            if (lleno2 == true && lleno == true)
            {
                Simulacion pase = new Simulacion();
                pase.Show();
                this.Close();
                pase.Analizador(texto, nombre, apellido, lineas);
            }
            if (lleno == false && lleno2 == false)
            {
                string mensajes = "No se han llenado los campos necesarios para continuar la simulación. Por favor, intente nuevamente";
                string nombres = "Error";
                MessageBoxButtons botoness = MessageBoxButtons.OK;
                DialogResult results;
                results = MessageBox.Show(mensajes, nombres, botoness);

            }
            else if (lleno2 == false)
            {
                string mensajes = "No se ha registrado a ningún piloto. Por favor, intente nuevamente";
                string nombres = "Error";
                MessageBoxButtons botoness = MessageBoxButtons.OK;
                DialogResult results;
                results = MessageBox.Show(mensajes, nombres, botoness);
            }
            else if (lleno == false)
            {
                string mensajes = "No se ha ingresado el archivo de texto. Por favor, intente nuevamente";
                string nombres = "Error";
                MessageBoxButtons botoness = MessageBoxButtons.OK;
                DialogResult results;
                results = MessageBox.Show(mensajes, nombres, botoness);
            }
        }



        private void B_RegistroDireccion_Click(object sender, EventArgs e)
        {
            try
            {
                Stream myst;
                String strFileName = ""; ;
                OpenFileDialog op = new OpenFileDialog();
                if (op.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    if ((myst = op.OpenFile()) != null)
                    {
                        strFileName = op.FileName;
                    }
                }
                //lector
                StreamReader reader1 = new StreamReader(strFileName);
                // leemos la linea
                texto = reader1.ReadToEnd();

                foreach (char caracteres in texto)
                {
                    if (caracteres == '\n' || caracteres == '\r')
                    {
                        texto = texto.Replace(caracteres, 'F');
                        if (caracteres == '\n')
                        {
                            lineas++;
                        }
                    }
                }
                texto = texto.Replace("F", "");
                B_RegistroDireccion.Enabled = false;
                lleno = true;
            }
            catch (Exception)
            {
                string mensaje = "No se ha subido ningún archivo. Por favor, ingrese correctamente el archivo.";
                string nombre = "Error";
                MessageBoxButtons botones = MessageBoxButtons.OK;
                DialogResult result;
                result = MessageBox.Show(mensaje, nombre, botones);
            }

        }
    }
}

