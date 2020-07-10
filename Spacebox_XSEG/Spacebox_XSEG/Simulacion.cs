using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Spacebox_XSEG
{
    public partial class Simulacion : Form
    {

        // ATRIBUTOS
        public char[,] tablero = new char[20, 20];
        public PictureBox[,] tabla = new PictureBox[20, 20];
        private string nombre, apellido, archivo, nave;
        private int puntuacion, espacios, movimientos, puntuacionmayor;
        int spacex, spacey, lineas;
        public bool ganador = false, flag = false, flag2 = false;

        //CONSTRUCTOR
        public Simulacion()
        {
            InitializeComponent();
            this.nombre = "";
            this.apellido = "";
            // puntuacion
            puntuacion = 0;
            // espacios recorridos
            espacios = 0;
            //puntuación mayor del jugador
            puntuacionmayor = 0;
        }

        private void Simulacion_Load(object sender, EventArgs e)
        {
            PB_cargando.Value = 0;
        }
        private void T_cargando_Tick(object sender, EventArgs e)
        {
            if (PB_cargando.Value < 100)
            {
                PB_cargando.Value++;
            }
            else
            {
                T_cargando.Enabled = false;
                T_cargando.Stop();
                PB_cargando.Visible = false;
                PanelInformación.Visible = true;
                B_Reinicio.Visible = true;
                Tablero_Principal.Visible = true;
                PB_csimulacion.Visible = false;
            }
        }


        public void Analizador(String entrada, string nombre, string apellido, int lineas)
        {
            bool banderaTierra = false, banderaSpaceBox = false; //identificadores si ya paso un spacebox, tierra, o si hay error.
            char caracter;
            int fila = 0;
            int columna = 0;
            this.lineas = lineas;

            if (entrada.Length == 400 && lineas == 19) // entra si hay 19 lineas y 400 caracteres
            {
                archivo = entrada;
                for (int i = 0; i < entrada.Length; i++)
                {
                    caracter = entrada[i]; //lenado de matriz 
                    if (columna == 20)
                    {
                        fila++;
                        columna = 0;
                    }
                    if (caracter == 'A' || caracter == 'C' || caracter == 'E')
                    {
                        tablero[columna, fila] = caracter;
                        columna++;
                    }
                    else if (caracter == 'B') // Spacebox 
                    {
                        if (banderaSpaceBox) // si ya habia entrado, truena
                        {
                            flag = true;
                            break;
                        }
                        else // de lo contrario, llena matriz
                        {
                            tablero[columna, fila] = caracter;
                            spacex = columna;
                            spacey = fila;
                            columna++;
                            banderaSpaceBox = true;
                        }
                    }
                    else if (caracter == 'D') // tierra
                    {
                        if (banderaTierra) // si ya habia entrado, truena
                        {
                            flag = true;
                            break;
                        }
                        else // de lo contrario, llena matriz
                        {
                            tablero[columna, fila] = caracter;
                            columna++;
                            banderaTierra = true;
                        }
                    }
                    else // cualquier otro caracter, truena
                    {
                        flag = true;
                        break;
                    }
                }

                if (banderaSpaceBox == false || banderaTierra == false)
                {
                    flag = true;
                    goto Error;
                }
                if (fila == 19) // si se completan las filas y todo está bien, sigue
                {
                    T_cargando.Enabled = true;
                    PB_cargando.Enabled = true;
                    PB_cargando.Visible = true;
                    Lector();
                    this.nombre = nombre;
                    this.apellido = apellido;
                    Nave();
                }
            }
            else // si la entrada no es de 400 chars, ni tiene 19 lineas, truena
            {
                flag = true;
            }
        Error:
            if (flag) // mensaje si truena
            {
                PB_csimulacion.Visible = false;
                T_cargando.Enabled = false;
                PB_cargando.Enabled = false;
                PB_cargando.Visible = false;
                string mensajes = "El archivo no cumple con los requisitos. Por favor intente de nuevo.";
                string nombres = "Error";
                MessageBoxButtons botoness = MessageBoxButtons.OK;
                DialogResult results;
                results = MessageBox.Show(mensajes, nombres, botoness);
                Ingreso_Info regreso = new Ingreso_Info();
                regreso.Show();
                this.Close();
            }
        }

        private void WinnerLoser_PB_Click(object sender, EventArgs e)
        {

        }

        public void Nave() // nombre de la nave
        {
            string letran = nombre.Substring(0, 1);
            string letraa = apellido.Substring(apellido.Length - 1);
            int total = nombre.Length + apellido.Length + 1;
            nave = "GUA-" + letran + letraa + "-" + total;
            TB_nave.Text = nave;
        }

        public void Lector() //asignación de picturebox
        {
            int h = Tablero_Principal.Height / 20;
            int w = Tablero_Principal.Width / 20;
            for (int i = 0; i < 20; i++)
            {
                for (int b = 0; b < 20; b++)
                {
                    if (tablero[i, b] == 'A')
                    {
                        tabla[i, b] = new PictureBox
                        {
                            Height = h,
                            Width = w,
                            Image = null,
                            Top = h * b,
                            Left = w * i,
                            BorderStyle = BorderStyle.FixedSingle
                        };
                    }
                    if (tablero[i, b] == 'B')
                    {
                        tabla[i, b] = new PictureBox
                        {
                            Height = h,
                            Width = w,
                            BackgroundImage = (Bitmap)Properties.Resources.ResourceManager.GetObject("spaceship1_1chiquito"),
                            BackgroundImageLayout = ImageLayout.Stretch,
                            Top = h * b,
                            Left = w * i,
                            BorderStyle = BorderStyle.FixedSingle,
                        };
                    }
                    if (tablero[i, b] == 'C')
                    {
                        tabla[i, b] = new PictureBox
                        {
                            Height = h,
                            Width = w,
                            BackgroundImage = (Bitmap)Properties.Resources.ResourceManager.GetObject("meteoritochiquito"),
                            BackgroundImageLayout = ImageLayout.Stretch,
                            Top = h * b,
                            Left = w * i,
                            BorderStyle = BorderStyle.FixedSingle
                        };
                    }
                    if (tablero[i, b] == 'D')
                    {
                        tabla[i, b] = new PictureBox
                        {
                            Height = h,
                            Width = w,
                            BackgroundImage = (Bitmap)Properties.Resources.ResourceManager.GetObject("nuevatierra"),
                            BackgroundImageLayout = ImageLayout.Stretch,
                            Top = h * b,
                            Left = w * i,
                            BorderStyle = BorderStyle.FixedSingle
                        };
                    }
                    if (tablero[i, b] == 'E')
                    {
                        tabla[i, b] = new PictureBox
                        {
                            Height = h,
                            Width = w,
                            BackgroundImage = (Bitmap)Properties.Resources.ResourceManager.GetObject("0dd2ed41a1dfcd9"),
                            BackgroundImageLayout = ImageLayout.Stretch,
                            Top = h * b,
                            Left = w * i,
                            BorderStyle = BorderStyle.FixedSingle
                        };
                    }
                    Tablero_Principal.Controls.Add(tabla[i, b]);
                }
            }
        }

        //MOVIMIENTOS
        // arriba
        public void MoverHaciaArriba()
        {
            int auxSpacexPos = spacex;
            int auxSpaceyPos = 0;
            int auxSpacey;
            try
            {
                for (auxSpacey = spacey - 1; auxSpacey >= -1; auxSpacey--)
                {
                    if (tablero[spacex, auxSpacey] == 'A' || tablero[spacex, auxSpacey] == 'B' && movimientos != 0)
                    {
                        espacios++;
                        tabla[spacex, auxSpacey].BackColor = Color.Black;
                    }
                    else if (tablero[spacex, auxSpacey] == 'E')
                    {
                        puntuacion += 100;
                        if (tabla[spacex, auxSpacey].BackgroundImage != null)
                        {
                            tabla[spacex, auxSpacey].BackgroundImage.Dispose();
                            tabla[spacex, auxSpacey].BackgroundImage = null;
                            tabla[spacex, auxSpacey].BackColor = Color.Black;
                        }
                        espacios++;
                    }
                    else if (tablero[spacex, auxSpacey] == 'C')
                    {
                        auxSpaceyPos += auxSpacey + 1;
                        break;
                    }
                    else if (tablero[spacex, auxSpacey] == 'D')
                    {
                        auxSpaceyPos = auxSpacey;
                        ganador = true;
                        break;
                    }
                    if (auxSpacey == 0 && tablero[spacex, auxSpacey] == 'A' || auxSpacey == 0 && tablero[spacex, auxSpacey] == 'B' || auxSpacey == 0 && tablero[spacex, auxSpacey] == 'E')
                    {
                        espacios++;
                        tabla[spacex, auxSpacey].BackColor = Color.Black;
                        flag2 = true;
                        break;
                    }
                }
                tabla[spacex, spacey].BackgroundImage.Dispose();
                tabla[spacex, spacey].BackgroundImage = null;
                tabla[auxSpacexPos, auxSpaceyPos].BackgroundImage = (Bitmap)Properties.Resources.ResourceManager.GetObject("spaceship1_1chiquito");
                tabla[auxSpacexPos, auxSpaceyPos].BackgroundImageLayout = ImageLayout.Stretch;
                if (flag2)
                {
                    Perdedor();
                }
                if (ganador)
                {
                    Ganador();
                }
                TB_Espacios.Text = espacios.ToString();
                TB_punteo.Text = puntuacion.ToString();
                spacey = auxSpaceyPos;

            }
            catch (Exception)
            {
                Perdedor();
            }
        }

        //abajo
        public void MoverHaciaAbajo()
        {
            int auxSpacexPos = spacex;
            int auxSpaceyPos = 0;
            int auxSpacey;
            try
            {

            for (auxSpacey = spacey + 1; auxSpacey <= 20; auxSpacey++)
            {
                if (tablero[spacex, auxSpacey] == 'A'|| tablero[spacex, auxSpacey] == 'B' && movimientos != 0)
                {
                    espacios++;
                    tabla[spacex, auxSpacey].BackColor = Color.Black;
                }
                else if (tablero[spacex, auxSpacey] == 'E')
                {
                    if (tabla[spacex, auxSpacey].BackgroundImage != null)
                    {
                        tabla[spacex, auxSpacey].BackgroundImage.Dispose();
                        tabla[spacex, auxSpacey].BackgroundImage = null;
                        tabla[spacex, auxSpacey].BackColor = Color.Black;
                        puntuacion += 100;
                    }
                    espacios++;
                }
                else if (tablero[spacex, auxSpacey] == 'C')
                {
                    auxSpaceyPos += auxSpacey - 1;
                    break;
                }
                else if (tablero[spacex, auxSpacey] == 'D')
                {
                    auxSpaceyPos = auxSpacey;
                    ganador = true;
                    break;
                }
                if (auxSpacey == 19 && tablero[spacex, auxSpacey] == 'A' || auxSpacey == 19 && tablero[spacex, auxSpacey] == 'B' || auxSpacey == 19 && tablero[spacex, auxSpacey] == 'E')
                {
                    tabla[spacex, auxSpacey].BackColor = Color.Black;
                    espacios++;
                    auxSpaceyPos = auxSpacey;
                    flag2 = true;
                    break;
                }
            }
            }
            catch (Exception)
            {
                Perdedor();
            }
            tabla[spacex, spacey].BackgroundImage.Dispose();
            tabla[spacex, spacey].BackgroundImage = null;
            tabla[auxSpacexPos, auxSpaceyPos].BackgroundImage = (Bitmap)Properties.Resources.ResourceManager.GetObject("spaceship1_1chiquito");
            tabla[auxSpacexPos, auxSpaceyPos].BackgroundImageLayout = ImageLayout.Stretch;
            spacey = auxSpaceyPos;
            if (flag2)
            {
                Perdedor();
            }
            if (ganador)
            {
                Ganador();
            }
            TB_Espacios.Text = espacios.ToString();
            TB_punteo.Text = puntuacion.ToString();
        }

        //derecha
        public void MoverALaDerecha()
        {
            int auxSpacexPos = 0;
            int auxSpaceyPos = spacey;
            int auxSpacex;
            try
            {

            for (auxSpacex = spacex + 1; auxSpacex <= 20; auxSpacex++)
            {
                if (tablero[auxSpacex, spacey] == 'A' || tablero[auxSpacex, spacey] == 'B' && movimientos != 0)
                {
                    tabla[auxSpacex, spacey].BackColor = Color.Black;
                    espacios++;
                }
                else if (tablero[auxSpacex, spacey] == 'E')
                {
                    puntuacion += 100;
                    if (tabla[auxSpacex, spacey].BackgroundImage != null)
                    {
                        tabla[auxSpacex, spacey].BackColor = Color.Black;
                        tabla[auxSpacex, spacey].BackgroundImage.Dispose();
                        tabla[auxSpacex, spacey].BackgroundImage = null;
                    }
                    espacios++;
                }
                else if (tablero[auxSpacex, spacey] == 'C')
                {
                    auxSpacexPos += auxSpacex - 1;
                    break;
                }
                else if (tablero[auxSpacex, spacey] == 'D')
                {
                    auxSpacexPos = auxSpacex;
                    ganador = true;
                    break;
                }
                if (auxSpacex == 19 && tablero[auxSpacex, spacey] == 'A' || auxSpacex == 19 && tablero[auxSpacex, spacey] == 'B' || auxSpacex == 19 && tablero[auxSpacex, spacey] == 'E')
                {
                    tabla[auxSpacex , spacey ].BackColor = Color.Black;
                    espacios++;
                    auxSpacexPos = auxSpacex;
                    flag2 = true;
                    break;
                }
            }
            }
            catch (Exception)
            {
                Perdedor();
            }
            tabla[spacex, spacey].BackgroundImage.Dispose();
            tabla[spacex, spacey].BackgroundImage = null;
            tabla[auxSpacexPos, auxSpaceyPos].BackgroundImage = (Bitmap)Properties.Resources.ResourceManager.GetObject("spaceship1_1chiquito");
            tabla[auxSpacexPos, auxSpaceyPos].BackgroundImageLayout = ImageLayout.Stretch;
            spacex = auxSpacexPos;
            if (flag2)
            {
                Perdedor();
            }
            if (ganador)
            {
                Ganador();
            }
            TB_Espacios.Text = espacios.ToString();
            TB_punteo.Text = puntuacion.ToString();
        }

        public void MoverALaIzquierda()
        {
            int auxSpacexPos = 0;
            int auxSpaceyPos = spacey;
            int auxSpacex;
            try
            {
                for (auxSpacex = spacex - 1; auxSpacex >= -1; auxSpacex--)
                {

                    if (tablero[auxSpacex, spacey] == 'A' || tablero[auxSpacex, spacey] == 'B' && movimientos != 0)
                    {
                        tabla[auxSpacex, spacey].BackColor = Color.Black;
                        espacios++;
                    }
                    else if (tablero[auxSpacex, spacey] == 'E')
                    {
                        if (tabla[auxSpacex, spacey].BackgroundImage != null)
                        {
                            tabla[auxSpacex, spacey].BackColor = Color.Black;
                            tabla[auxSpacex, spacey].BackgroundImage.Dispose();
                            tabla[auxSpacex, spacey].BackgroundImage = null;
                            puntuacion += 100;
                        }
                        espacios++;
                    }
                    else if (tablero[auxSpacex, spacey] == 'C')
                    {
                        auxSpacexPos += auxSpacex + 1;
                        break;
                    }
                    else if (tablero[auxSpacex, spacey] == 'D')
                    {
                        auxSpacexPos = auxSpacex;
                        ganador = true;
                        break;
                    }
                    if (auxSpacex == 0 && tablero[auxSpacex, spacey] == 'A' || auxSpacex == 0 && tablero[auxSpacex, spacey] == 'B' || auxSpacex == 0 && tablero[auxSpacex, spacey] == 'E')
                    {
                        tabla[auxSpacex, spacey].BackColor = Color.Black;
                        espacios++;
                        auxSpacexPos = auxSpacex;
                        flag2 = true;
                        break;
                    }
                }
            }
            catch (Exception)
            {
                Perdedor();
            }
            tabla[spacex, spacey].BackgroundImage.Dispose();
            tabla[spacex, spacey].BackgroundImage = null;
            tabla[auxSpacexPos, auxSpaceyPos].BackgroundImage = (Bitmap)Properties.Resources.ResourceManager.GetObject("spaceship1_1chiquito");
            tabla[auxSpacexPos, auxSpaceyPos].BackgroundImageLayout = ImageLayout.Stretch;
            spacex = auxSpacexPos;
            if (flag2)
            {
                Perdedor();
            }
            if (ganador)
            {
                Ganador();
            }
            TB_Espacios.Text = espacios.ToString();
            TB_punteo.Text = puntuacion.ToString();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Up)
            {
                MoverHaciaArriba();
                movimientos++;
            }
            if (keyData == Keys.Down)
            {
                MoverHaciaAbajo();
                movimientos++;
            }
            if (keyData == Keys.Right)
            {
                MoverALaDerecha();
                movimientos++;
            }
            if (keyData == Keys.Left)
            {
                MoverALaIzquierda();
                movimientos++;
            }
            TB_movimientos.Text = movimientos.ToString();
            return base.ProcessCmdKey(ref msg, keyData);
        }

        bool comprobacion = false;
        // si pierde 
        public void Perdedor()
        {
            string mensajes = "HOUSTON, WE GOT PROBLEMS...";
            string nombres = "Spacebox Perdido";
            MessageBoxButtons botoness = MessageBoxButtons.OK;
            DialogResult results;
            results = MessageBox.Show(mensajes, nombres, botoness);
            WinnerLoser_PB.Image = (Image)Properties.Resources.ResourceManager.GetObject("lostt");
            WinnerLoser_PB.Visible = true;
            Tablero_Principal.Visible = false;
            if (puntuacion > puntuacionmayor)
            {
                puntuacionmayor = puntuacion;
            }
            TB_puntuacionmayor.Text = puntuacionmayor.ToString();
            B_Reinicio.Visible = false;
            PanelInformación.Visible = false;
            comprobacion = true;
        }

        // si gana 
        public void Ganador()
        {
            string mensajes = "Estableciendo contacto con la tierra...";
            string nombres = "Objetivo logrado";
            MessageBoxButtons botoness = MessageBoxButtons.OK;
            DialogResult results;
            results = MessageBox.Show(mensajes, nombres, botoness);
            Tablero_Principal.Visible = false;
            WinnerLoser_PB.Image = (Image)Properties.Resources.ResourceManager.GetObject("giftierrafinal");
            WinnerLoser_PB.Visible = true;
            if (puntuacion > puntuacionmayor)
            {
                puntuacionmayor = puntuacion;
            }
            TB_puntuacionmayor.Text = puntuacionmayor.ToString();
            PanelInformación.Visible = false;
            B_Reinicio.Visible = false;
        }

        private void B_Reinicio_Click(object sender, EventArgs e)
        {//ganador == false && spacex == 19 || ganador == false && spacex == 0 || ganador == false && spacey == 19 || ganador == false && spacey == 0
            PB_cargando.Visible = false;
            if (comprobacion == true)
            {
                string message = "Nave " + nave + " fuera de los limites designados. Simulación perdida.\nPuntaje mayor: " + puntuacionmayor + "\n" + "Último puntaje: " + puntuacion + "\n" + "Espacios recorridos: " + espacios + "\n" + "Movimientos: " + movimientos + "\nMás suerte a la próxima piloto!";
                string name = "Misión no alcanzada";
                MessageBoxButtons boton = MessageBoxButtons.OK;
                DialogResult esultado;
                esultado = MessageBox.Show(message, name, boton);


                string mensajes = "¿Seguro deseas reiniciar?";
                string nombres = "Reinicio";
                MessageBoxButtons botoness = MessageBoxButtons.YesNo;
                DialogResult results;
                results = MessageBox.Show(mensajes, nombres, botoness);
                if (results == System.Windows.Forms.DialogResult.Yes)
                {
                    for (int i = 0; i < 20; i++)
                    {
                        for (int b = 0; b < 20; b++)
                        {
                            if (tabla[i, b].BackgroundImage != null)
                            {
                                tabla[i, b].BackgroundImage.Dispose();
                                tabla[i, b].BackgroundImage = null;
                            }
                            Tablero_Principal.Controls.Remove(tabla[i, b]);
                        }
                    }
                    movimientos = 0;
                    TB_movimientos.Text = movimientos.ToString();
                    puntuacion = 0;
                    espacios = 0;
                    TB_punteo.Text = puntuacion.ToString();
                    TB_Espacios.Text = espacios.ToString();
                    Analizador(archivo, nombre, apellido, lineas);
                    ganador = false;
                    flag2 = false;
                    WinnerLoser_PB.Visible = false;
                    PB_cargando.Enabled = false;
                    PB_cargando.Visible = false;
                    comprobacion = false;
                }
                else
                {
                    string mensaje = "¿Desea regresar al menú principal";
                    string nombre = "Reinicio";
                    MessageBoxButtons botones = MessageBoxButtons.YesNo;
                    DialogResult result;
                    result = MessageBox.Show(mensaje, nombre, botones);
                    if (result == System.Windows.Forms.DialogResult.Yes)
                    {
                        this.Close();
                        Inicio regreso = new Inicio();
                        regreso.Show();
                    }
                    else
                    {
                        string mensagge = "¿Desea salir";
                        string namee = "Reinicio";
                        MessageBoxButtons botonss = MessageBoxButtons.OK;
                        DialogResult rresultado;
                        rresultado = MessageBox.Show(mensagge, namee, botonss);
                        Application.ExitThread();
                    }
                }
            }
            else if (ganador == true)
            {
                if (puntuacion > puntuacionmayor)
                {
                    puntuacionmayor = puntuacion;
                }
                string message = "Felicidades piloto: " + this.nombre + ". Simulación completada con éxito.\nPuntaje mayor: " + puntuacionmayor + "\n" + "Último puntaje: " + puntuacion + "\n" + "Espacios recorridos: " + espacios + "\n" + "Movimientos: " + movimientos;
                string name = "Ganador";
                MessageBoxButtons boton = MessageBoxButtons.OK;
                DialogResult esultado;
                esultado = MessageBox.Show(message, name, boton);

                string mensajes = "¿Deseas reiniciar la simulación?";
                string nombres = "Reinicio";
                MessageBoxButtons botoness = MessageBoxButtons.YesNo;
                DialogResult results;
                results = MessageBox.Show(mensajes, nombres, botoness);
                if (results == System.Windows.Forms.DialogResult.Yes)
                {
                    for (int i = 0; i < 20; i++)
                    {
                        for (int b = 0; b < 20; b++)
                        {
                            if (tabla[i, b].BackgroundImage != null)
                            {
                                tabla[i, b].BackgroundImage.Dispose();
                                tabla[i, b].BackgroundImage = null;
                            }
                            Tablero_Principal.Controls.Remove(tabla[i, b]);
                        }
                    }
                    Analizador(archivo, nombre, apellido, lineas);
                    ganador = false;
                    flag2 = false;
                    WinnerLoser_PB.Visible = false;
                    PB_cargando.Enabled = false;
                    PB_cargando.Visible = false;
                    comprobacion = false;
                    movimientos = 0;
                    TB_movimientos.Text = movimientos.ToString();
                    espacios = 0;
                    TB_Espacios.Text = espacios.ToString();
                    puntuacion = 0;
                    TB_punteo.Text = puntuacion.ToString();
                }
                else
                {
                    string mensaje = "¿Desea regresar al menú principal";
                    string nombre = "Reinicio";
                    MessageBoxButtons botones = MessageBoxButtons.YesNo;
                    DialogResult result;
                    result = MessageBox.Show(mensaje, nombre, botones);
                    if (result == System.Windows.Forms.DialogResult.Yes)
                    {
                        this.Close();
                        Inicio regreso = new Inicio();
                        regreso.Show();
                    }
                    else
                    {
                        string messages = "¿Desea salir";
                        string names = "Reinicio";
                        MessageBoxButtons botone = MessageBoxButtons.OK;
                        DialogResult resultado;
                        resultado = MessageBox.Show(messages, names, botone);
                        Application.ExitThread();
                    }
                }
            }
            else
            {
                string mensajes = "¿Deseas reiniciar la simulación?";
                string nombres = "Reinicio";
                MessageBoxButtons botoness = MessageBoxButtons.YesNo;
                DialogResult results;
                results = MessageBox.Show(mensajes, nombres, botoness);
                if (results == System.Windows.Forms.DialogResult.Yes)
                {
                    for (int i = 0; i < 20; i++)
                    {
                        for (int b = 0; b < 20; b++)
                        {
                            if (tabla[i, b].BackgroundImage != null)
                            {
                                tabla[i, b].BackgroundImage.Dispose();
                                tabla[i, b].BackgroundImage = null;
                            }
                            Tablero_Principal.Controls.Remove(tabla[i, b]);
                        }
                    }
                    Analizador(archivo, nombre, apellido, lineas);
                    ganador = false;
                    flag2 = false;
                    WinnerLoser_PB.Visible = false;
                    PB_cargando.Enabled = false;
                    PB_cargando.Visible = false;
                    comprobacion = false;
                    movimientos = 0;
                    TB_movimientos.Text = movimientos.ToString();
                    espacios = 0;
                    TB_Espacios.Text = espacios.ToString(); 
                    puntuacion = 0;
                    TB_punteo.Text = puntuacion.ToString();
                }
            }
        }
    }
}
