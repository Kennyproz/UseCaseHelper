using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Use_Cases
{
    class Draw
    {
        
        int Y;
        int X;
        Pen MyPen;
        SolidBrush MyBrush;
        Font font;
        Graphics teken;
        Form2 newFormulier;
        public Draw (int Y, int X, Graphics teken)
        {
            MyPen = new Pen(Color.Black,2);
            MyBrush = new SolidBrush(Color.Black);
            font = new Font("Arial", 11);
            this.teken = teken;
            this.Y = Y;
            this.X = X;
        }
        public void DrawUseCase(int X, int Y, string text, List<Actors> ActorList, List<UseCase> Final)
        {   
            //Drawing the UseCase       
            teken.DrawEllipse(MyPen, X, Y, text.Length * 10, 40);
            teken.DrawString(text, font, MyBrush, X + 5, Y + 8);
            //Opening the UseCase
            newFormulier = new Form2(text);
            newFormulier.Case.Y = Y;
            newFormulier.Case.X = X;
            newFormulier.CbActoren.Refresh();
            newFormulier.CbActoren.DataSource = ActorList;
            newFormulier.CbActoren.SelectedIndex = -1;
            newFormulier.TbNaam.Text = newFormulier.Case.Naam;
            Final.Add(newFormulier.Case);
            newFormulier.Show();
        }
        public void deleteUseCase(string text, List<UseCase> Final)
        {
           
        }
        public void saveUseCase(List<UseCase> Final)
        {
            foreach (UseCase value in Final)
            {
                if (value.X+10 > X-30 && value.X+10 < X+20 && value.Y+10 > Y-20 && value.Y+10 < Y+20)
                {
                    MessageBox.Show(value.Naam + " has been Selected!");
                    Form2 OpenUseCase = new Form2(value);
                    OpenUseCase.Show();
                    
                }
                else
                {
                    return;
                    //Point point1 = new Point(80, 80);
                    //Point point2 = new Point(value.X+10, value.Y+10);
                    //teken.DrawLine(MyPen, point1, point2);
                    //teken.DrawRectangle(MyPen, X+10, Y+10,10,10);
                    //teken.DrawRectangle(MyPen, value.X, value.Y , 10, 10);
                    // MessageBox.Show("Nope");
                }
                
            }          
            
        }
    }
}
