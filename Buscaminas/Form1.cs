using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buscaminas
{
    public partial class Form1 : Form
    {

        private Timer timer;
        private DateTime startTime;
        private bool isRunning;


        public Form1()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
            timer = new Timer();
            timer.Interval = 100; // Intervalo de actualización del cronómetro en milisegundos
            timer.Tick += Timer_Tick;
        }

        private void botonProporcion_Click(object sender, EventArgs e)
        {
            if(!OpBasicas.EsNum(boxProporcion.Texts))
            {
                RJMessageBox.Show("Ingrese un valor de tipo númerico");
            }
            else
            {
                int proporcion = int.Parse(boxProporcion.Texts);
                if (proporcion < 4 || proporcion >25)
                {
                    RJMessageBox.Show("Ingrese un número mayor a 4 y menor a " +
                        "25 para poder " +
                        "iniciar el juego");
                }
                else
                {
                    panelTablero = OpBasicas.IniciarTablero(panelTablero, proporcion);
                    CambiarModo();
                    fotoModo.Visible = true;
                    boxProporcion.Visible = false;
                    botonProporcion.Visible = false;
                    label1.Visible = false;
                    modo.Visible = true;
                    Crono();
                }
            }
        }
        
        private void CambiarModo()
        {
            if(OpBasicas.flag2)
            {
                OpBasicas.flag2 = false;
                fotoModo.Image = Buscaminas.Properties.Resources.bandera;
                modo.Text = "Poner bandera";
                
            }
            else
            {
                OpBasicas.flag2 = true;
                fotoModo.Image = Buscaminas.Properties.Resources.mina;
                modo.Text = "buscar casillas vácias";
            }
        }

        private void clickFoto(object sender, EventArgs e)
        {
            CambiarModo();
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            // Calcular el tiempo transcurrido
            TimeSpan elapsedTime = DateTime.Now - startTime;

            // Actualizar la etiqueta con el tiempo transcurrido
            timeLabel.Text = elapsedTime.ToString(@"hh\:mm\:ss");
        }
        public void Crono()
        {
            if (isRunning)
            {
                // Detener el cronómetro
                timer.Stop();
                isRunning = false;
            }
            else
            {
                // Iniciar el cronómetro o reiniciarlo
                startTime = DateTime.Now;
                timer.Start();
                timeLabel.Visible = true;
                isRunning = true;
            }
        }
        public void Reiniciar()
        {
            DialogResult respuesta = RJMessageBox.Show("¿Desea reiniciar el juego?", "Info", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta == DialogResult.No)
            {

            }
            else
            {
                label1.Visible = true;
                boxProporcion.Visible = true;
                fotoModo.Visible = false;
                botonProporcion.Visible = true;
                modo.Visible = false;
                panelTablero = OpBasicas.ReiniciarJuego(panelTablero);
            }
        }
    }
}
