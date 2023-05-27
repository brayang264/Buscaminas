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
    public class ButtonSwitch : CheckBox
    {
        //Campos de apariencia
        private Color onBackColor = Color.DeepSkyBlue;
        private Color onToggleColor = Color.WhiteSmoke;
        private Color offBackColor = Color.DarkGray;
        private Color offToggleColor = Color.Gainsboro;
        private bool solidStyle = true;

        [Category("Personalizar")]
        public Color OnBackColor 
        {
            get
            {
                return onBackColor;
            }
            set
            {
                onBackColor = value;
                this.Invalidate();
            }
        }
        [Category("Personalizar")]
        public Color OnToggleColor
        {
            get 
            { 
                return offBackColor; 
            }
            set
            {
                offBackColor = value;
                this.Invalidate ();
            }
        }
        [Category("Personalizar")]
        public Color OffBackColor
        {
            get
            {
                return offBackColor;
            }
            set
            {
                offBackColor = value;
                this.Invalidate ();
            }
        }
        [Category("Personalizar")]
        public Color OffToggleColor
        { 
            get
            {
                return offBackColor;
            }
            set
            {
                offBackColor = value;
                this.Invalidate ();
            } 
        }
        [Category("Personalizar")]
        public override string Text
        {
            get
            {
                return base.Text;
            }
        }
        [Category("Personalizar")]
        [DefaultValue(true)]
        public bool SolidStyle
        {
            get
            {
                return solidStyle;
            }
            set 
            {
                solidStyle = value;
                this.Invalidate ();
            }
        }


        //Constructor
        public ButtonSwitch()
        {

            this.MinimumSize = new Size(42, 22);

        }

        //Metodos
        private GraphicsPath GetFigurePath()
        {
            int arcSize = this.Height - 1;
            Rectangle leftArc = new Rectangle(0, 0, arcSize, arcSize);
            Rectangle rigthArc = new Rectangle(this.Width-arcSize-2,0, arcSize, arcSize);

            //ruta de graficos
            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(leftArc, 90, 180);
            path.AddArc(rigthArc, 270, 180);
            path.CloseFigure();
            return path;
        }

        //Anular evento pintura del control

        protected override void OnPaint(PaintEventArgs pevent)
        {
            //tamaño palanca
            int toggleSize = this.Height - 5;
            pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            pevent.Graphics.Clear(this.Parent.BackColor);

            if(this.Checked) //encendido
            {
                //dibujo de superficie de control
                if (solidStyle)
                    pevent.Graphics.FillPath(new SolidBrush(onBackColor), GetFigurePath());
                else pevent.Graphics.DrawPath(new Pen(OnBackColor,2),GetFigurePath());
                //dibujar palanca
                pevent.Graphics.FillEllipse(new SolidBrush(onToggleColor), new Rectangle(
                    this.Width - this.Height + 1, 2, toggleSize, toggleSize));
            }
            else //Apagado
            {

                //dibujo de superficie de control
                if (solidStyle)
                    pevent.Graphics.FillPath(new SolidBrush(offBackColor), GetFigurePath());
                else pevent.Graphics.DrawPath(new Pen(OffBackColor, 2), GetFigurePath());
                //dibujar palanca
                pevent.Graphics.FillEllipse(new SolidBrush(offToggleColor), new Rectangle(
                    2, 2, toggleSize, toggleSize));

            }
        }

    }
}
