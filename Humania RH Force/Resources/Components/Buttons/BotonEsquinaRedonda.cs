using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Drawing;

namespace Humania_RH_Force.Resources.Components.Buttons
{
    public class BotonEsquinaRedonda : Button
    {
        //Campos
        private int borderSize = 0;
        private int borderRadius = 40;
        private Color borderColor = Color.PaleVioletRed;

        public int BorderSize
        { 
            get 
            {
                return borderSize; 
            }
            set 
            {    
                borderSize = value;
                this.Invalidate();
            } 
        }
        public int BorderRadius 
        { get 
            { 
                return borderRadius; 
            }
            set  
            { 
                borderRadius = value;
                this.Invalidate();
            }
        }
        public Color BorderColor
        {
            get
            { 
                return borderColor; 
            }
            set 
            { 
                borderColor = value;
                this.Invalidate();
            }
        }
        public Color BackgroundColor
        {
            get { return this.BackColor; }
            set { this.BackColor = value; }
        }
        public Color TextColor
        {
            get { return this.ForeColor; }
            set { this.ForeColor = value; }
        }
        //Constructor
        public BotonEsquinaRedonda()
        {
            this.FlatStyle = FlatStyle.Flat;
            this.FlatAppearance.BorderSize = 0;
            this.Size = new Size(150, 40);
            this.BackColor = Color.Cyan;
            this.ForeColor = Color.Black;
            this.Resize += new EventHandler(Button_Resize);
        }

        private void Button_Resize(object? sender, EventArgs e)
        {
            if (borderRadius > this.Height)
                BorderRadius = this.Height;
        }

        //Metodos
        private GraphicsPath GetFigurePath(RectangleF rect, float radius)
        {
            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
            path.AddArc(rect.Width - radius, rect.Y, radius, radius, 270, 90);
            path.AddArc(rect.Width - radius, rect.Height - radius, radius, radius, 0, 90);
            path.AddArc(rect.X, rect.Height - radius, radius, radius, 90, 90);
            path.CloseFigure();
            return path;
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);
            pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            RectangleF rectSurFace = new RectangleF(0, 0, this.Width, this.Height);
            RectangleF rectBorder = new RectangleF(1, 1, this.Width - 0.8F, this.Height - 1);

            if (borderRadius > 2) //Aparecera el boton con esquina redondeada
            {
                using (GraphicsPath pathSurFace = GetFigurePath(rectSurFace, borderRadius))
                using (GraphicsPath pathBorder = GetFigurePath(rectBorder, borderRadius - 1F))
                using (Pen penSurFace = new Pen(this.Parent.BackColor, 2))
                using (Pen penBorder = new Pen(borderColor, borderSize))
                {
                    penBorder.Alignment = PenAlignment.Inset;
                    //Superficie del boton
                    this.Region = new Region(pathSurFace);
                    //dibujar borde de superficie para resultado HD
                    pevent.Graphics.DrawPath(penSurFace, pathSurFace);

                    //Borde del boton
                    if (borderSize >= 1)
                        //Dibujar el control del borde
                        pevent.Graphics.DrawPath(penSurFace, pathBorder);
                }
            }
            else //Boton normal
            {
                //Superficie del boton
                this.Region = new Region(rectSurFace);
                //Borde del boton
                if (borderSize >= 1)
                {
                    using (Pen penBorder = new Pen(borderColor, borderSize))
                    {
                        penBorder.Alignment = PenAlignment.Inset;
                        pevent.Graphics.DrawRectangle(penBorder, 0, 0, this.Width - 1, this.Height - 1);
                    }
                }
            }
        }
        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            this.Parent.BackColorChanged += new EventHandler(Container_BackColorChanged);
        }

        private void Container_BackColorChanged(object? sender, EventArgs e)
        {
            if (this.DesignMode)
                this.Invalidate();
        }
    }
}
