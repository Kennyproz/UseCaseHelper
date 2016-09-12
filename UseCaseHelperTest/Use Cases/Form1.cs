using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Use_Cases
{
    public partial class Form1 : Form
    {
        public List<UseCase> UseCases = new List<UseCase>();
        public List<Actors> Actoren = new List<Actors>();
        Actors ActorOne;
        Actors ActorTwo;
        Actors ActorThree;
        Graphics g;
        Pen MyPen = new Pen(Color.Black, 4);


        public Form1()
        {
            InitializeComponent();
            hideActors();   
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<UseCase> ErrorFix = new List<UseCase>();//https://www.dotnetperls.com/invalidoperationexception
            if (g != null)
            {
                 g.Clear(Color.White);
                foreach(UseCase item in UseCases)
                {
                    if (UseCases.Count != 0)
                    {
                        ErrorFix.Add(item);
                    }
                }
                foreach (UseCase item in ErrorFix)
                {
                    UseCases.Remove(item);
                }
            }
            else
            {
                MessageBox.Show("Nothing to Clear!");
            }
        }
        private void hideActors()
        {
            //Hide Actors
            pbActorOne.Hide();
            pbActorTwo.Hide();
            pbActorThree.Hide();
        }
        private void actorsadding(Actors actor, int x)
        {
            actor.X1 = x;
            actor.Y1 = 90;
            actor.AddActor(tbActorName.Text);
            Actoren.Add(actor);
        }
        private void addRemoveActors()
        {
            //Add Actors
            if (rbAdd.Checked && rbActor.Checked == true)
            {
                if (pbActorOne.Visible == false)
                {
                    if (tbActorName.Text != "")
                    {
                     ActorOne = new Actors(tbActorName.Text, lbActorOne, pbActorOne);
                     actorsadding(ActorOne, 100);
                    }
                    else
                    {
                        MessageBox.Show("The actor needs a name!");
                    }
                }
                else if (pbActorOne.Visible && pbActorTwo.Visible == false)
                {
                    if (tbActorName.Text != "")
                    {
                        ActorTwo = new Actors(tbActorName.Text, lbActorTwo, pbActorTwo);
                        actorsadding(ActorTwo, 250); 
                    }
                    else
                    {
                        MessageBox.Show("The actor needs a name!");
                    }
                }
                else if (pbActorOne.Visible && pbActorTwo.Visible && pbActorThree.Visible == false)
                {
                    if (tbActorName.Text != "")
                    {
                        ActorThree = new Actors(tbActorName.Text, lbActorTwo, pbActorThree);
                        actorsadding(ActorThree, 390);
                    }
                    else
                    {
                        MessageBox.Show("The actor needs a name!");
                    }
                }
                else
                {
                    MessageBox.Show("3 is the Maximum!");
                }
            }

            //Remove Actors
            else if (rbRemove.Checked && rbActor.Checked == true)
            {
                if (ActorOne.Name == tbActorName.Text)
                {
                    ActorOne.Select = false;
                    ActorOne.RemoveActor();
                    Actoren.Remove(ActorOne);
                }
                else if (ActorTwo.Name == tbActorName.Text)
                {
                    ActorTwo.Select = false;
                    ActorTwo.RemoveActor();
                    Actoren.Remove(ActorTwo);
                }
                else if (ActorThree.Name == tbActorName.Text)
                {
                    ActorThree.Select = false;
                    ActorThree.RemoveActor();
                    Actoren.Remove(ActorThree);
                }
                else
                {
                    MessageBox.Show("No Actors to remove!");
                }
            }
        }

        private void pbTeken_MouseClick(object sender, MouseEventArgs e)
        {
            g = pbTeken.CreateGraphics();
            // om de lijnen mooier te maken (https://msdn.microsoft.com/en-us/library/system.drawing.graphics.smoothingmode(v=vs.110).aspx)
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            addRemoveActors();
            Draw drawings = new Draw(e.Y, e.X, g);
            
            //Drawing UseCases
            if (rbAdd.Checked && rbUseCase.Checked == true)
            {
               drawings.Drawline(UseCases, Actoren);
                if (tbUseCaseName.Text != "")
                {
                    drawings.DrawUseCase(e.X, e.Y, tbUseCaseName.Text,Actoren,UseCases);
                }
                else
                {
                    MessageBox.Show("Oops, No Use Case Name!");
                }
            }
            else if (rbRemove.Checked && rbUseCase.Checked)
            {
                //drawings.Drawline(UseCases, Actoren);
                drawings.deleteUseCase(UseCases);
            }
            if (rbEdit.Checked && rbUseCase.Checked)
            {
                drawings.Selected(UseCases,Actoren);
            }
            //Drawline
            if (rbLine.Checked && rbAdd.Checked)
            {
                drawings.Drawline(UseCases,Actoren);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

    }
}
