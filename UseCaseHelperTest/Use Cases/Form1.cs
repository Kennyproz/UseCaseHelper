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
        public Form1()
        {
            InitializeComponent();
            hideActors();
        }
        public List<UseCase> UseCases = new List<UseCase>();
        public List<Actors> Actoren = new List<Actors>();
        public List<Form2> Cases = new List<Form2>();
        Actors ActorOne;
        Actors ActorTwo;
        Actors ActorThree;

        Graphics g;
        Pen MyPen = new Pen(Color.Black, 4);

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (g != null)
            {
                g.Clear(Color.White);
                foreach(UseCase item in UseCases)
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
            pbActorOne.Hide();
            pbActorTwo.Hide();
            pbActorThree.Hide();
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
                        ActorOne.X1 = 100;
                        ActorOne.Y1 = 90;
                        ActorOne.AddActor(tbActorName.Text);
                        Actoren.Add(ActorOne);
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
                        ActorTwo.Y1 = 250;
                        ActorTwo.X1 = 100;
                        ActorTwo.AddActor(tbActorName.Text);
                        Actoren.Add(ActorTwo);
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
                        ActorThree = new Actors(tbActorName.Text, lbActorThree, pbActorThree);
                        ActorThree.Y1 = 350;
                        ActorThree.X1 = 118; 
                        ActorThree.AddActor(tbActorName.Text);
                        Actoren.Add(ActorThree);
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
                    ActorOne.RemoveActor();
                    Actoren.Remove(ActorOne);
                }
                else if (ActorTwo.Name == tbActorName.Text)
                {
                    ActorTwo.RemoveActor();
                    Actoren.Remove(ActorTwo);
                }
                else if (ActorThree.Name == tbActorName.Text)
                {
                    ActorThree.RemoveActor();
                    Actoren.Remove(ActorThree);
                }
                else
                {
                    MessageBox.Show("No Actors to remove!");
                }
            }
        }

        private void drawLine()
        {
            if (rbLine.Checked && rbEdit.Checked)
            {

            }
        }

        private void pbTeken_MouseClick(object sender, MouseEventArgs e)
        {
            g = pbTeken.CreateGraphics();
            addRemoveActors();
            Draw drawings = new Draw(e.Y, e.X, g);
            
            //Drawing UseCases
            if (rbAdd.Checked && rbUseCase.Checked == true)
            {
                if (tbUseCaseName.Text != "")
                {
                    drawings.DrawUseCase(e.X, e.Y, tbUseCaseName.Text,Actoren,UseCases);
                    drawings.Drawline(UseCases, Actoren); 
                }
                else
                {
                    MessageBox.Show("Oops, No Use Case Name!");
                }
            }
            else if (rbRemove.Checked && rbUseCase.Checked)
            {
                drawings.deleteUseCase(UseCases);
            }
            if (rbEdit.Checked && rbUseCase.Checked)
            {
                drawings.Selected(UseCases,Actoren);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

    }
}
