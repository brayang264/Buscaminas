using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buscaminas
{
    internal class OpBasicas
    {

        //Matriz de referencia para el juego
        public static int[,] tableroReferencia = new int[1,1];
        //listas y parametros
        public static List<Panel> casillas = new List<Panel>();
        public static List<int> rows = new List<int>();
        public static List<int> cols = new List<int>();
        public static List<bool> click = new List<bool>();
        public static int numMinas = 0;
        public static int NumCasillasVacias = 0;
        public static int numTotalCasillas = 0;

        //Se inicia el panel con el la cantidad X por X que el usuario digito
        public static Panel IniciarTablero(Panel tablero, int BoardSize)
        {
            Color LightSquareColor = ColorTranslator.FromHtml("#3e7b32"); 
            Color DarkSquareColor = ColorTranslator.FromHtml("#104f0c");
            int tamaño1 = tablero.Width / BoardSize;
            int tamaño2 = tablero.Height / BoardSize;
            numTotalCasillas = BoardSize;
            for (int row = 0; row < BoardSize; row++)
            {
                for (int col = 0; col < BoardSize; col++)
                {
                    Panel square = new Panel();
                    square.Size = new Size(tamaño1, tamaño2);
                    square.Location = new Point(col * tamaño1, row * tamaño2);
                    square.BackColor = (row + col) % 2 == 0 ? LightSquareColor : DarkSquareColor;
                    square.Cursor = Cursors.Hand;
                    //Agregar si la casilla tiene una mina o no.
                    
                    square.Click += new EventHandler(Perder);
                    tablero.Controls.Add(square);
                    casillas.Add(square);
                    cols.Add(col);
                    rows.Add(row);
                    click.Add(false);
                }

            }
            IniciarMatris(BoardSize);
            return tablero;
        }


        //Bandera para el modo de poner banderas o buscar las minas
        public static bool flag1 = true;
        public static bool flag2 = true;

        //Metodo para comprobar que todavia no haya perdido
        private static void Perder(object sender, EventArgs e)
        {
            if(flag2)
            {
                Panel ficha = (Panel)sender;
                int index = casillas.IndexOf(ficha);
                int row = rows[index];
                int col = cols[index];
                //Este es para plsar en donde no haya una mina 
                if (flag1)
                {
                    if (!click[index])
                    {
                        if (tableroReferencia[row, col] == 1)
                        {
                            RJMessageBox.Show("Perdiste\nUna lastimas, suerte para la proxima", "Retirese mas bien", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            click[index] = true;
                            flag2 = false;
                        }
                        else
                        {
                            RJMessageBox.Show("Te haz salvado cachón", "Buena hpta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            click[index] = true;
                            NumCasillasVacias--;
                            ficha.BackColor = ColorTranslator.FromHtml("#eaa353");
                            int num = NumeroDeMinasAlLado(rows[index], cols[index]);
                            if(NumCasillasVacias == 0)
                            {
                                RJMessageBox.Show("Ganaste");
                                flag2 = false;
                            }
                            else
                            {
                                switch(num)
                                {
                                    case 1:
                                        ficha.BackgroundImage = Buscaminas.Properties.Resources.uno;
                                        break;
                                    case 2:
                                        ficha.BackgroundImage = Buscaminas.Properties.Resources.dos;
                                        break;
                                    case 3:
                                        ficha.BackgroundImage = Buscaminas.Properties.Resources.tres;
                                        break;
                                    case 4:
                                        ficha.BackgroundImage = Buscaminas.Properties.Resources.cuatro;
                                        break;
                                    case 5:
                                        ficha.BackgroundImage = Buscaminas.Properties.Resources.cinco;
                                        break;
                                    case 6:
                                        ficha.BackgroundImage = Buscaminas.Properties.Resources.seis;
                                        break;
                                    case 7:
                                        ficha.BackgroundImage = Buscaminas.Properties.Resources.siete;
                                        break;
                                    case 8:
                                        ficha.BackgroundImage = Buscaminas.Properties.Resources.ocho;
                                        break;
                                    default: 
                                        break;
                                }
                                ficha.BackgroundImageLayout = ImageLayout.Zoom;
                            }
                        }
                    }

                }
                //Este es para pulsar en donde este una mina.
                else
                {

                }
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
                    matiz[i, j] = 0;
                }
            }
            tableroReferencia = matiz;
            AñadirMinas(proporcion);
        }

        //Añadir si es mina o está salvado;
        public static void AñadirMinas(int proporcion)
        {
            Random numeroDeMinas = new Random();
            int minas = numeroDeMinas.Next(proporcion*2,(proporcion*proporcion/2)+1);
            numMinas = minas;
            NumCasillasVacias = (proporcion * proporcion) - minas;
            RJMessageBox.Show(minas + "");
            int cont = 0;
            //aqui se ponen las minas
            while ( cont < minas )
            {

                int fila = numeroDeMinas.Next(0, proporcion);
                int colum = numeroDeMinas.Next(0, proporcion);
                if (tableroReferencia[fila, colum]==0)
                {
                    tableroReferencia[fila, colum] = 1;
                    cont++;
                }
            }
            RJMessageBox.Show(ImprimirMatriz(tableroReferencia));
        }

        //Mostrar matriz
        public static string ImprimirMatriz(int[,] matriz)
        {
            string respuesta = "";
            for(int i = 0;i < matriz.GetLength(0);i++)
            {
                for( int j = 0;j < matriz.GetLength(1);j++)
                {
                    respuesta += " | " + matriz[i, j] + "";
                }
                respuesta += " | \n";
            }
            return respuesta;
        }
        //metodo para comprobar cuantas minas al despues de hacer click en una casillla
        //sin minas
        public static int NumeroDeMinasAlLado(int row, int col)
        {
            int cont = 0;
            //esquinas
            if(row == 0 && col == 0)
            {
                if (tableroReferencia[row, col+1] == 1)
                { cont++; }
                if (tableroReferencia[row+1,col+1] ==1)
                { cont++; }
                if (tableroReferencia[row+1,col] ==1)
                { cont++; }
            }
            else if(row == 0 && col == numTotalCasillas-1)
            {
                if (tableroReferencia[row,col-1]==1)
                { cont++; }
                if (tableroReferencia[row+1, col-1]==1)
                { cont++; }
                if (tableroReferencia[row+1,col]==1)
                { cont++; }
            }
            else if(row==numTotalCasillas-1 && col==0)
            {
                if (tableroReferencia[row-1,col]==1)
                { cont++; }
                if (tableroReferencia[row-1,col+1]==1)
                { cont++; }
                if (tableroReferencia[row,col+1]==1)
                { cont++; }
            }
            else if(row == numTotalCasillas-1 && col == numTotalCasillas-1)
            {
                if (tableroReferencia[row,col-1]==1)
                { cont++; }
                if (tableroReferencia[row-1,col-1]==1)
                { cont++; }
                if (tableroReferencia[row-1,col]==1)
                { cont++; }
            }
            //bordes
            else if(col ==0)
            {
                if (tableroReferencia[row-1,col]==1)
                { cont++; }
                if (tableroReferencia[row-1,col+1]==1)
                { cont++; }
                if (tableroReferencia[row,col+1]==1)
                { cont++; }
                if (tableroReferencia[row+1,col+1]==1)
                { cont++; }
                if (tableroReferencia[row+1,col]==1)
                { cont++; }


            }
            else if(col == numTotalCasillas-1)
            {
                if (tableroReferencia[row - 1, col] == 1)
                { cont++; }
                if (tableroReferencia[row - 1, col - 1] == 1)
                { cont++; }
                if (tableroReferencia[row, col - 1] == 1)
                { cont++; }
                if (tableroReferencia[row + 1, col - 1] == 1)
                { cont++; }
                if (tableroReferencia[row + 1, col] == 1)
                { cont++; }
            }
            else if(row==0)
            {
                if (tableroReferencia[row,col+1] == 1)
                { cont++; }
                if (tableroReferencia[row+1,col+1] ==1)
                { cont++; }
                if (tableroReferencia[row+1,col]==1)
                { cont++; }
                if (tableroReferencia[row+1,col-1] == 1)
                { cont++; }
                if (tableroReferencia[row,col-1]==1)
                { cont++; }

            }
            else if(row == numTotalCasillas-1)
            {
                if (tableroReferencia[row, col + 1] == 1)
                { cont++; }
                if (tableroReferencia[row - 1, col + 1] == 1)
                { cont++; }
                if (tableroReferencia[row - 1, col] == 1)
                { cont++; }
                if (tableroReferencia[row - 1, col - 1] == 1)
                { cont++; }
                if (tableroReferencia[row, col - 1] == 1)
                { cont++; }
            }
            //Ninguna de las anteriores
            else
            {
                if (tableroReferencia[row-1,col] == 1)
                { cont++; }
                if (tableroReferencia[row-1,col+1] == 1)
                { cont++; }
                if (tableroReferencia[row,col+1]==1)
                { cont++; }
                if (tableroReferencia[row+1,col+1]==1)
                { cont++; }
                if (tableroReferencia[row+1,col] == 1)
                { cont++; }
                if (tableroReferencia[row+1,col-1] == 1)
                { cont++; }
                if (tableroReferencia[row,col-1]==1)
                { cont++; }
                if (tableroReferencia[row-1,col-1] == 1)
                { cont++; }
            }

            return cont;
        }
        //Metodo para conprobar que el número ingresado por el  usuario sea valido
        public static bool EsNum(string num)
        {
            bool x = int.TryParse(num, out int y);
            return x;
        }

    }
}
