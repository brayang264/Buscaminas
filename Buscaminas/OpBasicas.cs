using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buscaminas
{
    internal class OpBasicas
    {

        //Matriz de referencia para el juego
        public static int[,] tablero;
        public static List<Panel> casillas = new List<Panel>();

        //Se inicia el panel con el la cantidad X por X que el usuario digito
        public static Panel IniciarTablero(Panel tablero, int BoardSize)
        {
            Color LightSquareColor = Color.White; 
            Color DarkSquareColor = Color.DarkGray;
            int tamaño1 = tablero.Width / BoardSize;
            int tamaño2 = tablero.Height / BoardSize;
            for (int row = 0; row < BoardSize; row++)
            {
                for (int col = 0; col < BoardSize; col++)
                {
                    Panel square = new Panel();
                    square.Size = new Size(tamaño1, tamaño2);
                    square.Location = new Point(col * tamaño1, row * tamaño2);
                    square.BackColor = (row + col) % 2 == 0 ? LightSquareColor : DarkSquareColor;
                    square.BackgroundImage = Buscaminas.Properties.Resources.casilla;
                    square.BackgroundImageLayout = ImageLayout.Stretch;
                    square.Cursor = Cursors.Hand;
                    square.Click += new EventHandler(Perder);
                    tablero.Controls.Add(square);
                    casillas.Add(square);
                }

            }
            return tablero;
        }


        //Bandera para el modo de poner banderas o buscar las minas
        public static bool flag1 = false;

        //Metodo para comprobar que todavia no haya perdido
        private static void Perder(object sender, EventArgs e)
        {
            Panel ficha = (Panel)sender;
            if (flag1)
            {

            }
        }

        //Iniciar matriz
        public static void IniciarMatris(int proporcion)
        {
            int[,] matiz = new int[proporcion, proporcion];
            for(int i = 0; i < matiz.GetLength(0); i++)
            {
                for(int j = 0; j < matiz.GetLength(1); j++)
                {
                    matiz[i, j] = -1;
                }
            }
            tablero = matiz;
        }

        //Añadir si es mina o está salvado;
        public void AñadirMinas()
        {

        }

        //Metodo para conprobar que el número ingresado por el  usuario sea valido
        public static bool EsNum(string num)
        {
            bool x = int.TryParse(num, out int y);
            return x;
        }
    }
}
