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
        bool Select = false;
        Pen MyPen;
        Pen MyPenRed;
        Pen MyPenGum;
        SolidBrush MyBrush;
        SolidBrush MyGum;
        Font font;
        Graphics teken;
        Form2 newFormulier;
        public Draw (int Y, int X, Graphics teken)
        {
            MyPen = new Pen(Color.Black,2);
            MyPenRed = new Pen(Color.Red, 2);
            MyBrush = new SolidBrush(Color.Black);
            MyGum = new SolidBrush(Color.White);
            MyPenGum = new Pen(Color.White, 2);
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
        public void deleteUseCase(List<UseCase> DeleteCases)
        {
            foreach (UseCase DeleteCase in DeleteCases) 
            {
                if (DeleteCases != null && DeleteCase.Select == true)
                {
                    teken.DrawEllipse(MyPenGum, DeleteCase.X, DeleteCase.Y, DeleteCase.Naam.Length * 10, 40);
                    teken.FillEllipse(MyGum, DeleteCase.X, DeleteCase.Y, DeleteCase.Naam.Length * 10, 40);
                    DeleteCases.Remove(DeleteCase);
                }
                else
                {
                    MessageBox.Show("No UseCases to delete!");
                }
            }
           
        }
        public void Selected(List<UseCase> SelectedCases)
        { 
            foreach (UseCase SelectedC in SelectedCases)
            {
                if (SelectedC.X + 10 > X - 30 && SelectedC.X + 10 < X + 20 && SelectedC.Y + 10 > Y - 20 && SelectedC.Y + 10 < Y + 20)
                {
                    SelectedC.Select = true;
                    teken.DrawEllipse(MyPenRed, SelectedC.X, SelectedC.Y, SelectedC.Naam.Length * 10, 40);
                    MessageBox.Show(SelectedC.Naam + " has been Selected!");
                    Form2 OpenUseCase = new Form2(SelectedC);
                    OpenUseCase.Show();
                }
                else
                {
                    DeSelected(SelectedCases);
                }
                
            }
            
        }
        public void DeSelected(List<UseCase> CaseList)
        {

            foreach (UseCase DeSelectedCase in CaseList)
            {
                if (Select == true)
                {
                    return;
                }
                else if (Select == false)
                {
                    teken.DrawEllipse(MyPen, DeSelectedCase.X, DeSelectedCase.Y, DeSelectedCase.Naam.Length * 10, 40);
                    // MessageBox.Show(DeSelectedCase.Naam + " has been deselected!");
                }
            }
        }
        public void saveUseCase()
        {
           
                    //Point point1 = new Point(80, 80);
                    //Point point2 = new Point(value.X+10, value.Y+10);
                    //teken.DrawLine(MyPen, point1, point2);
                    //teken.DrawRectangle(MyPen, X+10, Y+10,10,10);
                    //teken.DrawRectangle(MyPen, value.X, value.Y , 10, 10);
                    // MessageBox.Show("Nope");
                
                
                   
            
        }
    }
}
