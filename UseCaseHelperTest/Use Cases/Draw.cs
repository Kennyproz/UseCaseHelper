using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Use_Cases
{
    class Draw
    {
        Graphics teken;
        int Y;
        int X;
        Pen MyPen;
        SolidBrush MyBrush;
        Font font;
        public Draw (int Y, int X, Graphics teken)
        {
            MyPen = new Pen(Color.Black,4);
            MyBrush = new SolidBrush(Color.Black);
            font = new Font("Roboto", 12);
            this.teken = teken;
            this.Y = Y;
            this.X = X;
        }
        public void DrawUseCase(int X, int Y, string text)
        {
            teken.DrawEllipse(MyPen, X, Y, text.Length * 10, 40);
            teken.DrawString(text, font, MyBrush, X + 5, Y + 8);
        }
    }
}
