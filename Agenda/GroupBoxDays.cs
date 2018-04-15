using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agenda
{
    public class GroupBoxDays : GroupBox
    {
        private Color _borderColor = Color.Black;
        private Rectangle borderRect;

        public Color BorderColor
        {
            get { return this._borderColor; }
            set { this._borderColor = value; }
        }

        protected override void OnPaint(PaintEventArgs e)
        {

            //get the text size in groupbox
            Size tSize = TextRenderer.MeasureText(this.Text, this.Font);

            Rectangle borderRect = e.ClipRectangle;
            this.borderRect = borderRect;

            Rectangle textRect = e.ClipRectangle;
            textRect.X = (textRect.X + 6);
            textRect.Width = tSize.Width;
            textRect.Height = tSize.Height;
            e.Graphics.FillRectangle(new SolidBrush(this.BackColor), textRect);
            e.Graphics.DrawString(this.Text, this.Font, new SolidBrush(this.ForeColor), textRect);

            if (!this.Text.Equals(""))
            {
                this._borderColor = Color.Navy;
                ControlPaint.DrawBorder(e.Graphics, borderRect, this._borderColor, ButtonBorderStyle.Solid);
            }
        }

        public void getColors(Color backColor, Color foreColor)
        {
            this.BackColor = backColor;
            this.ForeColor = foreColor;
        }
    }
}