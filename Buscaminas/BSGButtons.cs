using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.ComponentModel;

namespace Buscaminas
{
    //Se hereda de la clase boton
    public class BSGButtons : Button
    {
        //Apariencia de los botones
        private int borderSize = 0;
        private int borderRadius = 40;
        private Color borderColor = Color.PaleVioletRed;

        //Propiedades
        [Category("BSG Más Ajustes de Colores")]
        public int BorderSize { 
            get
            {
               return borderSize;
            } set
            {
                borderSize = value;
                this.Invalidate();
            }
        }
        [Category("Más Ajustes de Colores y Estilos")]

        public int BorderRadius { get
            {
                return borderRadius;
            }
            set
            {
                borderRadius = value;
                this.Invalidate();
            }
        }
        [Category("BSG Más Ajustes de Colores")]
        public Color BorderColor { get
            {
                return borderColor;
            }
            set
            {
                borderColor = value;
                this.Invalidate();
            } 
        }

        //cambiar color de fondo
        public Color BackgroundColor
        {
            get { return this.BackColor; }
            set { this.BackColor = value; }
        }
        [Category("BSG Más Ajustes de Colores")]
        //Color de texto
        public Color TextColor
        {
            get { return this.ForeColor; }
            set { this.ForeColor = value; }
        }

        //Constructor
        public BSGButtons()
        {
            this.FlatStyle = FlatStyle.Flat;
            this.FlatAppearance.BorderSize = 0;
            this.Size = new Size(150, 40);
            this.BackColor = Color.MediumSlateBlue;
            this.ForeColor = Color.White;
            this.Resize += new EventHandler(Button_Resize);
        }

        private void Button_Resize(object sender, EventArgs e)
        {
            if(borderRadius>this.Height)
                BorderRadius = this.Height;
        }

        //Metodos
        private GraphicsPath GetFiguerePath(RectangleF rect, float radius)
        {
            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(rect.X, rect.Y, radius, radius,180,90);
            path.AddArc(rect.Width-radius, rect.Y, radius, radius, 270, 90);
            path.AddArc(rect.Width - radius, rect.Height-radius, radius, radius, 0, 90);
            path.AddArc(rect.X, rect.Height - radius, radius, radius, 90, 90);
            path.CloseFigure();

            return path;
        }


        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);
            pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            RectangleF rectSurFace = new RectangleF(0,0,this.Width,this.Height);
            RectangleF rectBorder = new RectangleF(1,1,this.Width-0.8f,this.Height-1);

            if(borderRadius>2) //Esquinas redondeadas
            {
                using (GraphicsPath pathSurFace = GetFiguerePath(rectSurFace, borderRadius))
                using (GraphicsPath pathBorder = GetFiguerePath(rectBorder, borderRadius - 1f))
                using (Pen penSurface = new Pen(this.Parent.BackColor,2))
                using (Pen penBorder = new Pen(borderColor, borderSize))
                {
                    penBorder.Alignment = PenAlignment.Inset;

                    //superficie del botón
                    this.Region = new Region(pathSurFace);

                    //Dibujo del borde de la superficie
                    pevent.Graphics.DrawPath(penSurface,pathSurFace);
                    //Dibujar el borde del boton
                    if(borderSize >=1)
                        pevent.Graphics.DrawPath(penBorder,pathBorder);
                }
            }
            else //Botón normal
            {
                //superficie del botón
                this.Region = new Region(rectSurFace);
                //borde del botón
                if(borderSize>=1)
                {
                    using (Pen penBorder=new Pen(borderColor,borderSize))
                    {
                        penBorder.Alignment= PenAlignment.Inset;
                        pevent.Graphics.DrawRectangle(penBorder,0,0,this.Width-1,this.Height-1);

                    }
                }
            }
        }

        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            this.Parent.BackColorChanged += new EventHandler(Container_BackColorChanged);
        }

        private void Container_BackColorChanged(object sender, EventArgs e)
        {
            if(this.DesignMode)
                this.Invalidate();
        }
    }
}
