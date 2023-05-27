using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Reflection;
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
        public static Panel[,] panels = new Panel[1,1];
        //listas y parametros
        public static List<Panel> casillas = new List<Panel>();
        public static List<int> rows = new List<int>();
        public static List<int> cols = new List<int>();
        public static List<bool> click = new List<bool>();
        public static List<bool> colorSegundario = new List<bool>();
        public static List<bool> banderaPuesta = new List<bool>();
        public static int numMinas = 0;
        public static int NumCasillasVacias = 0;
        public static int numTotalCasillas = 0;
        public static int cantBanderas = 0;

        //Se inicia el panel con el la cantidad X por X que el usuario digito
        public static Panel IniciarTablero(Panel tablero, int BoardSize)
        {
            Color LightSquareColor = ColorTranslator.FromHtml("#3e7b32"); 
            Color DarkSquareColor = ColorTranslator.FromHtml("#104f0c");
            Panel[,] paneles = new Panel[BoardSize,BoardSize];
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
                    colorSegundario.Add((row + col) % 2 == 0 ? true : false);
                    banderaPuesta.Add(false);
                    square.Cursor = Cursors.Hand;
                    //Agregar si la casilla tiene una mina o no.
                    
                    square.Click += new EventHandler(Perder);
                    tablero.Controls.Add(square);
                    paneles[row, col] = square;
                    casillas.Add(square);
                    cols.Add(col);
                    rows.Add(row);
                    click.Add(false);
                }

            }
            IniciarMatris(BoardSize);
            panels = paneles;
            return tablero;
        }


        //Bandera para el modo de poner banderas o buscar las minas
        public static bool flag1 = true;
        public static bool flag2 = false;

        //Metodo para comprobar que todavia no haya perdido
        public static bool primerClick = false;
        private static void Perder(object sender, EventArgs e)
        {
            if(!primerClick)
            {
                AñadirMinas(numTotalCasillas);
            }
            Panel ficha = (Panel)sender;
            int index = casillas.IndexOf(ficha);
            int row = rows[index];
            int col = cols[index];
            if (flag2)
            {

                //Este es para plsar en donde no haya una mina 
                if (flag1)
                {
                    if (!click[index])
                    {
                        
                        if(primerClick == false && tableroReferencia[row,col]==1)
                        {
                            tableroReferencia[row,col ] = 0;
                            primerClick = true;
                        }
                        else
                        {
                            primerClick = true;
                        }
                        if (tableroReferencia[row, col] == 1 && primerClick == true)
                        {
                            RJMessageBox.Show("Perdiste\nUna lastimas, suerte para la proxima", "Retirese mas bien", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            click[index] = true;
                            flag1 = false;
                        }
                        else
                        {
                            click[index] = true;
                            NumCasillasVacias--;
                            ficha.BackColor = colorSegundario[index] ? ColorTranslator.FromHtml("#eaa353") : ColorTranslator.FromHtml("#e0be7e");
                            int num = NumeroDeMinasAlLado(rows[index], cols[index]);
                            if (NumCasillasVacias == 0)
                            {
                                RJMessageBox.Show("Ganaste");
                                flag1 = false;
                            }
                            else
                            {
                                switch (num)
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
                                        Limpiar(rows[index], cols[index], e);
                                        break;
                                }
                                ficha.BackgroundImageLayout = ImageLayout.Zoom;
                            }
                        }
                    }

                }
            }
            //Este es para pulsar en donde este una mina.
            else
            {
                if (flag1 == false)
                {
                    return;
                }
                if (!banderaPuesta[index])
                {
                    if (click[index])
                    {
                        return;
                    }
                    if (cantBanderas == 0)
                    {
                        RJMessageBox.Show("No hay mas banderas disponibles");
                    }
                    else
                    {
                        ficha.BackgroundImage = Buscaminas.Properties.Resources._2bandera;
                        ficha.BackgroundImageLayout = ImageLayout.Stretch;
                        banderaPuesta[index] = true;
                        click[index] = true;
                        HayMina(row, col, banderaPuesta[index]);
                        if (numMinas == 0)
                        {
                            RJMessageBox.Show("Has Ganado");
                            flag1 = false;
                        }
                    }

                }
                else
                {
                    ficha.BackgroundImage = null;
                    banderaPuesta[index] = false;
                    click[index] = false;
                    HayMina(row, col, banderaPuesta[index]);
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
            //AñadirMinas(proporcion);
        }

        //Añadir si es mina o está salvado;
        public static void AñadirMinas(int proporcion)
        {
            Random numeroDeMinas = new Random();
            int minas = numeroDeMinas.Next(proporcion+proporcion,(proporcion*proporcion/4)+1);
            numMinas = minas;
            cantBanderas = minas;
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
        public static void Limpiar(int row, int col, EventArgs e)
        {
            //esquinas
            if (row == 0 && col == 0)
            {
                if (tableroReferencia[row, col + 1] == 0)
                {
                    Panel panel = panels[row, col + 1];
                    Perder(panel, e);
                }
                if (tableroReferencia[row + 1, col + 1] == 0)
                {
                    Panel panel = panels[row + 1, col + 1];
                    Perder(panel, e);
                }
                if (tableroReferencia[row + 1, col] == 0)
                {
                    Panel panel = panels[row + 1, col];
                    Perder(panel, e);
                }
            }
            else if (row == 0 && col == numTotalCasillas - 1)
            {
                if (tableroReferencia[row, col - 1] == 0)
                {
                    Panel panel = panels[row, col - 1];
                    Perder(panel, e);
                }
                if (tableroReferencia[row + 1, col - 1] == 0)
                {
                    Panel panel = panels[row + 1, col - 1];
                    Perder(panel, e);
                }
                if (tableroReferencia[row + 1, col] == 0)
                {
                    Panel panel = panels[row + 1, col];
                    Perder(panel, e);
                }
            }
            else if (row == numTotalCasillas - 1 && col == 0)
            {
                if (tableroReferencia[row - 1, col] == 0)
                {
                    Panel panel = panels[row - 1, col];
                    Perder(panel, e);
                }
                if (tableroReferencia[row - 1, col + 1] == 0)
                {
                    {
                        Panel panel = panels[row - 1, col + 0];
                        Perder(panel, e);
                    }
                }
                if (tableroReferencia[row, col + 1] == 0)
                {
                    Panel panel = panels[row, col + 1];
                    Perder(panel, e);
                }
            }
            else if (row == numTotalCasillas - 1 && col == numTotalCasillas - 1)
            {
                if (tableroReferencia[row, col - 1] == 0)
                {
                    Panel panel = panels[row, col - 1];
                    Perder(panel, e);
                }
                if (tableroReferencia[row - 1, col - 1] == 0)
                {
                    {
                        Panel panel = panels[row - 1, col - 1];
                        Perder(panel, e);
                    }
                }
                if (tableroReferencia[row - 1, col] == 0)
                {
                    Panel panel = panels[row - 1, col];
                    Perder(panel, e);
                }
            }
            //bordes
            else if (col == 0)
            {
                if (tableroReferencia[row - 1, col] == 0)
                {
                    Panel panel = panels[row - 1, col];
                    Perder(panel, e);
                }
                if (tableroReferencia[row - 1, col + 1] == 0)
                {
                    Panel panel = panels[row - 1, col + 1];
                    Perder(panel, e);
                }
                if (tableroReferencia[row, col + 1] == 0)
                {
                    {
                        Panel panel = panels[row, col + 1];
                        Perder(panel, e);
                    }
                }
                if (tableroReferencia[row + 1, col + 1] == 0)
                {
                    Panel panel = panels[row + 1, col + 1];
                    Perder(panel, e);
                }
                if (tableroReferencia[row + 1, col] == 0)
                {
                    {
                        Panel panel = panels[row + 1, col];
                        Perder(panel, e);
                    }
                }


            }
            else if (col == numTotalCasillas - 1)
            {
                if (tableroReferencia[row - 1, col] == 0)
                {
                    Panel panel = panels[row - 1, col];
                    Perder(panel, e);
                }
                if (tableroReferencia[row - 1, col - 1] == 0)
                {
                    Panel panel = panels[row - 1, col - 1];
                    Perder(panel, e);
                }
                if (tableroReferencia[row, col - 1] == 0)
                {
                    Panel panel = panels[row, col - 1];
                    Perder(panel, e);
                }
                if (tableroReferencia[row + 1, col - 1] == 0)
                {
                    {
                        Panel panel = panels[row+1, col - 1];
                        Perder(panel, e);
                    }
                }
                if (tableroReferencia[row + 1, col] == 0)
                {
                    {
                        Panel panel = panels[row+1, col];
                        Perder(panel, e);
                    }
                }
            }
            else if (row == 0)
            {
                if (tableroReferencia[row, col + 1] == 0)
                {
                    Panel panel = panels[row, col + 1];
                    Perder(panel, e);
                }
                if (tableroReferencia[row + 1, col + 1] == 0)
                {
                    Panel panel = panels[row+1, col + 1];
                    Perder(panel, e);
                }
                if (tableroReferencia[row + 1, col] == 0)
                {
                    Panel panel = panels[row + 1, col];
                    Perder(panel, e);
                }
                if (tableroReferencia[row + 1, col - 1] == 0)
                {
                    Panel panel = panels[row + 1, col - 1];
                    Perder(panel, e);
                }
                if (tableroReferencia[row, col - 1] == 0)
                {
                    Panel panel = panels[row , col - 1];
                    Perder(panel, e);
                }

            }
            else if (row == numTotalCasillas - 1)
            {
                if (tableroReferencia[row, col + 1] == 0)
                {
                    Panel panel = panels[row, col + 1];
                    Perder(panel, e);
                }
                if (tableroReferencia[row - 1, col + 1] == 0)
                {
                    Panel panel = panels[row-1, col + 1];
                    Perder(panel, e);
                }
                if (tableroReferencia[row - 1, col] == 0)
                {
                    Panel panel = panels[row-1, col];
                    Perder(panel, e);
                }
                if (tableroReferencia[row - 1, col - 1] == 0)
                {
                    Panel panel = panels[row-1, col - 1];
                    Perder(panel, e);
                }
                if (tableroReferencia[row, col - 1] == 0)
                {
                    Panel panel = panels[row, col - 1];
                    Perder(panel, e);
                }
            }
            //Ninguna de las anteriores
            else
            {
                if (tableroReferencia[row - 1, col] == 0)
                {
                    Panel panel = panels[row - 1, col];
                    Perder(panel, e);
                }
                if (tableroReferencia[row - 1, col + 1] == 0)
                {
                    Panel panel = panels[row-1, col + 1];
                    Perder(panel, e);
                }
                if (tableroReferencia[row, col + 1] == 0)
                {
                    Panel panel = panels[row, col + 1];
                    Perder(panel, e);
                }
                if (tableroReferencia[row + 1, col + 1] == 0)
                {
                    Panel panel = panels[row+1, col + 1];
                    Perder(panel, e);
                }
                if (tableroReferencia[row + 1, col] == 0)
                {
                    Panel panel = panels[row+1, col];
                    Perder(panel, e);
                }
                if (tableroReferencia[row + 1, col - 1] == 0)
                {
                    Panel panel = panels[row+1, col - 1];
                    Perder(panel, e);
                }
                if (tableroReferencia[row, col - 1] == 0)
                {
                    Panel panel = panels[row, col - 1];
                    Perder(panel, e);
                }
                if (tableroReferencia[row - 1, col - 1] == 0)
                {
                    Panel panel = panels[row-1, col - 1];
                    Perder(panel, e);
                }
            }
        }
        //Metodo para saber si hay mina en la posicion
        public static void HayMina(int row,int col, bool bandera)
        {
            if (!bandera)
            {
                if (tableroReferencia[row, col] == 1)
                {
                    numMinas++;
                }
                cantBanderas++;
            }
            else
            {
                if (tableroReferencia[row, col] == 1)
                {
                    numMinas--;
                }
                cantBanderas--;
            }
        }
        //Metodo para conprobar que el número ingresado por el  usuario sea valido
        public static bool EsNum(string num)
        {
            bool x = int.TryParse(num, out int y);
            return x;
        }

    }
}
