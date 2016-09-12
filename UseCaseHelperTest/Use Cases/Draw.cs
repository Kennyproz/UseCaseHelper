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
        public Draw(int Y, int X, Graphics teken)
        {
            MyPen = new Pen(Color.Black, 2);
            MyPenRed = new Pen(Color.Red, 2);
            MyBrush = new SolidBrush(Color.Black);
            MyGum = new SolidBrush(Color.White);
            MyPenGum = new Pen(Color.White, 4);
            font = new Font("Arial", 11);
            this.teken = teken;
            this.Y = Y;
            this.X = X;
        }
        public void DrawUseCase(int X, int Y, string text, List<Actors> ActorList, List<UseCase> Final)
        {
            //Drawing the UseCase       
            teken.DrawEllipse(MyPen, X, Y, text.Length * 10, 40);
            teken.DrawString(text, font, MyBrush, X + text.Length / 2, Y + 8);
            //Opening the UseCase
            newFormulier = new Form2(text);
            newFormulier.Case.Y = Y;
            newFormulier.Case.X = X;
            newFormulier.TbNaam.Text = newFormulier.Case.Naam;
            Final.Add(newFormulier.Case);
            opening(newFormulier, ActorList);
        }
        public void deleteUseCase(List<UseCase> UseCases)
        {
            List<UseCase> ErrorFix = new List<UseCase>(); 
            foreach (UseCase SelectedC in UseCases)
            {
                if (SelectedC.X + 10 > X - 30 && SelectedC.X + 10 < X + 20 && SelectedC.Y + 10 > Y - 20 && SelectedC.Y + 10 < Y + 20)
                {
                    //SelectedC.Select = true;
                    drawGum(SelectedC,MyPenGum,MyGum);
                    foreach (Actors actor in SelectedC.Actors)
                    {
                        drawActorLine(SelectedC, actor, MyPenGum);
                    }
                    ErrorFix.Add(SelectedC);
                    MessageBox.Show(SelectedC.Naam + " has been Removed!");
                }
                else
                {
                    DeSelected(UseCases);
                }
            }
            foreach (UseCase item in ErrorFix)
            {
                UseCases.Remove(item);
                drawGum(item,MyPenGum,MyGum);
            }
        }
        public void Selected(List<UseCase> UseCases, List<Actors> Actorlist)
        {
            foreach (UseCase SelectedC in UseCases)
            {
                if (SelectedC.X + 10 > X - 30 && SelectedC.X + 10 < X + 20 && SelectedC.Y + 10 > Y - 20 && SelectedC.Y + 10 < Y + 20)
                {
                    SelectedC.Select = true;
                    drawGum(SelectedC,MyPenGum,MyGum);
                    teken.DrawEllipse(MyPenRed, SelectedC.X, SelectedC.Y, SelectedC.Naam.Length * 10, 40);
                    teken.DrawString(SelectedC.Naam, font, MyBrush, SelectedC.X + SelectedC.Naam.Length / 2, SelectedC.Y + 8);
                    MessageBox.Show(SelectedC.Naam + " has been Selected!");
                    Form2 OpenUseCase = new Form2(SelectedC);
                    opening(OpenUseCase, Actorlist);
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
        public void Drawline(List<UseCase> Usecases, List<Actors> Actors)
        {

            foreach (UseCase usecase in Usecases)
            {
               // if (usecase.Select == true)
                {
                    foreach (Actors actor in usecase.Actors)
                    {
                        if (actor.Select == true)
                        {
                            drawActorLine(usecase, actor,MyPen);
                        }
                        else if (actor.Select == false)
                        {
                            drawActorLine(usecase, actor, MyPenGum);
                        }
                    }
                }
            }

        }
        private void drawGum(UseCase item,Pen pen, SolidBrush brush)
        {
            teken.DrawEllipse(pen, item.X, item.Y, item.Naam.Length * 10, 40);
            teken.FillEllipse(brush, item.X, item.Y, item.Naam.Length * 10, 40);
        }
        private void drawActorLine(UseCase item, Actors actor, Pen pen)
        {
            Point point1 = new Point(actor.X1, actor.Y1);
            Point point2 = new Point(item.X, item.Y + 20);
            teken.DrawLine(pen, point1, point2);
        }
        private void opening(Form2 form2,List<Actors> actors)
        {
            form2.CbActoren.Refresh();
            form2.CbActoren.DataSource = actors;
            form2.CbActoren.SelectedIndex = -1;
            form2.Show();
        }
    }
}
