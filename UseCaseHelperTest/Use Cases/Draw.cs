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
            //newFormulier.listbActoren.DataSource = newFormulier.Case.Actors;
            Final.Add(newFormulier.Case);
            newFormulier.Show();
        }
        public void deleteUseCase(List<UseCase> UseCases)
        {
            if (UseCases != null)
            {
                List<UseCase> usecaselist = new List<UseCase>();
                foreach (UseCase DeleteCase in UseCases)
                {
                    if (DeleteCase.X + 10 > X - 30 && DeleteCase.X + 10 < X + 20 && DeleteCase.Y + 10 > Y - 20 && DeleteCase.Y + 10 < Y + 20)
                    {
                        DeleteCase.Select = true;
                    }

                    if (UseCases != null && DeleteCase.Select == true)
                    {
                        teken.DrawEllipse(MyPenGum, DeleteCase.X, DeleteCase.Y, DeleteCase.Naam.Length * 10, 40);
                        teken.FillEllipse(MyGum, DeleteCase.X, DeleteCase.Y, DeleteCase.Naam.Length * 10, 40);
                        usecaselist.Add(DeleteCase);
                    }
                    else
                    {
                        MessageBox.Show("No UseCases to delete!");
                    }
                }
                foreach (UseCase DeleteCase in usecaselist)
                {
                    UseCases.Remove(DeleteCase);
                }
            }
           
        }
        public void Selected(List<UseCase> UseCases,List<Actors> Actorlist)
        { 
            foreach (UseCase SelectedC in UseCases)
            {
                if (SelectedC.X + 10 > X - 30 && SelectedC.X + 10 < X + 20 && SelectedC.Y + 10 > Y - 20 && SelectedC.Y + 10 < Y + 20)
                {
                    // SelectedC.Select = true;
                    Drawline(UseCases, Actorlist);
                    teken.DrawEllipse(MyPenGum, SelectedC.X, SelectedC.Y, SelectedC.Naam.Length * 10, 40);
                    teken.FillEllipse(MyGum, SelectedC.X, SelectedC.Y, SelectedC.Naam.Length * 10, 40);
                    teken.DrawEllipse(MyPenRed, SelectedC.X, SelectedC.Y, SelectedC.Naam.Length * 10, 40);
                    teken.DrawString(SelectedC.Naam, font, MyBrush, SelectedC.X + 5, SelectedC.Y + 8);
                    MessageBox.Show(SelectedC.Naam + " has been Selected!");
                    Form2 OpenUseCase = new Form2(SelectedC);
                    
                    OpenUseCase.CbActoren.Refresh();
                    OpenUseCase.CbActoren.DataSource = Actorlist;
                    OpenUseCase.CbActoren.SelectedIndex = -1;
                    Drawline(UseCases, Actorlist);
                    OpenUseCase.Show();
                }
                else
                {
                    DeSelected(UseCases);
                }
            }
            
        }
        public void DeSelected(List<UseCase> Usecases)
        {

            foreach (UseCase DeSelectedCase in Usecases)
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
        public void Drawline(List<UseCase> Usecases,List<Actors> Actors)
        {
            foreach (Actors actor in Actors)
            {
                if (actor.Select == true)
                {
                    if (newFormulier != null)
                    {
                        Point point1 = new Point(actor.X1, actor.Y1);
                        Point point2 = new Point(newFormulier.Case.X + 10, newFormulier.Case.Y + 10);
                        teken.DrawLine(MyPen, point1, point2);
                    }
                }
                else
                {
                    return;
                }
            }
         

            //foreach (UseCase usecase in Usecases)
            //{

            //    if (usecase.Actors.Count)

            //}


            //Point point1 = new Point(80, 80);

            //teken.DrawLine(MyPen, point1, point2);
            //teken.DrawRectangle(MyPen, X+10, Y+10,10,10);
            //teken.DrawRectangle(MyPen, value.X, value.Y , 10, 10);
            // MessageBox.Show("Nope");




        }
    }
}
