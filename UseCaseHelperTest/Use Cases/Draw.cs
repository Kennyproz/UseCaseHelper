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
        List<UseCase> Case = new List<UseCase>();
        public List<Graphics> items = new List<Graphics>();
        public List<UseCase> UseCases = new List<UseCase>();
        public Draw (int Y, int X, Graphics teken)
        {
            MyPen = new Pen(Color.Black,2);
            MyBrush = new SolidBrush(Color.Black);
            font = new Font("Roboto", 12);
            this.teken = teken;
            this.Y = Y;
            this.X = X;
        }
        public void DrawUseCase(int X, int Y, string text, List<Actors> ActorList)
        {    
            teken.DrawEllipse(MyPen, X, Y, text.Length * 10, 40);
            teken.DrawString(text, font, MyBrush, X + 5, Y + 8);
            
            Form2 newFormulier = new Form2(text);
            newFormulier.Case.Y = Y;
            newFormulier.Case.X = X;
            UseCases.Add(newFormulier.Case);
            newFormulier.CbActoren.Refresh();
            newFormulier.CbActoren.DataSource = ActorList;
            newFormulier.CbActoren.SelectedIndex = -1;
            newFormulier.TbNaam.Text = newFormulier.Case.Naam;
            newFormulier.Show();
            items.Add(teken);
        }
        public void deleteUseCase(string text)
        {
            items.Remove(teken);
        }
        private void saveUseCase()
        {
           
        }
    }
}
