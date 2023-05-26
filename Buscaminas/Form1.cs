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
        public Form1()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
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
                if (proporcion < 4 || proporcion >50)
                {
                    RJMessageBox.Show("Ingrese un número mayor a 4 y menor a " +
                        "50 para poder " +
                        "iniciar el juego");
                }
                else
                {
                    panelTablero = OpBasicas.IniciarTablero(panelTablero, proporcion);
                    CambiarModo();
                    fotoModo.Visible = true;

                }
            }
        }
        
        private void CambiarModo()
        {
            if(OpBasicas.flag2)
            {
                OpBasicas.flag2 = false;
                fotoModo.Image = Buscaminas.Properties.Resources.bandera;
            }
            else
            {
                OpBasicas.flag2 = true;
                fotoModo.Image = Buscaminas.Properties.Resources.mina;
            }
        }

        private void clickFoto(object sender, EventArgs e)
        {
            CambiarModo();
        }
    }
}
