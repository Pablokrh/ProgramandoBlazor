using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.ComponentModel;

namespace Botones
{
    public class BotonesPersonalizados: Button
    {
        //Fields
        private int borderSize = 0;
        private int borderRadius = 40;
        private Color borderColor = Color.PaleVioletRed;

        [Category("RJ Code Advance 1/6/23")]
        public int BorderSize
        {
            get => borderSize;
            set 
            {
                borderSize = value;
                this.Invalidate();                    
            }
             
        }
        [Category("RJ Code Advance 1/6/23")]
        public int BorderRadius
        {
            get => borderRadius;
            set
            {
                borderRadius = value;
                this.Invalidate();

            }
        }
        [Category("RJ Code Advance 1/6/23")]
        public Color BorderColor
        {
            get => borderColor;
            set
            {
                borderColor = value;
                this.Invalidate();

            }
        }
        [Category("RJ Code Advance 1/6/23")]
        public Color BackGround
        {
            get { return this.BackColor; }
            set { this.BackColor = value; }

        }

        [Category("RJ Code Advance 1/6/23")]
        public Color TextColor
        {
            get { return this.ForeColor; }
            set { this.ForeColor = value; }

        }

        //Construttore
        public BotonesPersonalizados()
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
            if (borderRadius > this.Height)
                BorderRadius = this.Height;
            //Esto establece una restricción para establecer el radio del borde, porque si el radio es mas grande el botón se rompe.
        }

        //Methods
        private GraphicsPath  GetFigurePath(RectangleF rect, float radius)
        {
            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(rect.X, rect.Y, radius, radius, 180, 90); 
            path.AddArc(rect.Width-radius, rect.Y, radius, radius, 270, 90); 
            path.AddArc(rect.Width - radius, rect.Height-radius, radius, radius, 0, 90); 
            path.AddArc(rect.X, rect.Height - radius, radius, radius, 90, 90);
            //Se añade un arco por cada esquina que se desea modificar
            path.CloseFigure();
            return path;
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);
            pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            //Lo primero que hace es suavizar la pintura.

            //A continuación crea rectangulos flotantes para la superficies del botón. El primero mas grande que el segundo, ya que el segundo es para el borde:
            RectangleF rectSurface = new RectangleF(0, 0, this.Width, this.Height);
            RectangleF rectBorder = new RectangleF(1, 1, this.Width - 0.8f, this.Height - 1);

            //Si el radio del borde es mayor que 2 será un botón con esquinas redondeadas, si no será uno normal:
            if (BorderRadius > 2) //Será el botón redondeado
            {
                using (GraphicsPath pathSurface = GetFigurePath(rectSurface, BorderRadius))
                using (GraphicsPath pathBorder=GetFigurePath(rectBorder,BorderRadius-1f))
                using (Pen penSurface= new Pen (this.Parent.BackColor,2))
                using (Pen penBorder=new Pen (BorderColor,BorderSize))
                {
                    penBorder.Alignment = PenAlignment.Inset;
                    this.Region = new Region(pathSurface);

                    //A continuación se dibuja el borde de la superficie para que tengan buena calidad.
                    pevent.Graphics.DrawPath(penSurface, pathSurface);

                    if (BorderSize >= 1)
                    {
                        pevent.Graphics.DrawPath(penBorder, pathBorder);
                    }
                }
            }

            else //Será el botón normal
            {
                this.Region = new Region(rectSurface);
                if (BorderSize >= 1)
                {
                    using (Pen penBorder = new Pen(BorderColor, BorderSize))
                    {
                        penBorder.Alignment = PenAlignment.Inset;
                        pevent.Graphics.DrawRectangle(penBorder, 0, 0, this.Width - 1, this.Height - 1);
                    }

                }
            
            
            }
        }
        //Dice que este método es el que mas se parece al formLoad. 
        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            //Superficie y contenedor deben tener el mismo color. Si el form cambia de color, el botón también debe hacerlo:
            this.Parent.BackColorChanged += new EventHandler(Container_BackColorChanged);
        }

        private void Container_BackColorChanged(object sender, EventArgs e)
        {
            if (this.DesignMode)
                this.Invalidate();
        }
    }
}
