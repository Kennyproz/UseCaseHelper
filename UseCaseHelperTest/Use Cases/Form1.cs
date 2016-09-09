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

        //private void addForms()
        //{
        //    Form2 newFormulier = new Form2(tbUseCaseName.Text);
        //    UseCases.Add(newFormulier.Case);
        //    newFormulier.CbActoren.Refresh();
        //    newFormulier.CbActoren.DataSource = Actoren;
        //    newFormulier.TbNaam.Text = newFormulier.Case.Naam;
        //    newFormulier.Show();
        //}
        private void EditForms()
        {

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
                }
                else
                {
                    MessageBox.Show("Oops, No Use Case Name!");
                }
            }
            else if (rbRemove.Checked && rbUseCase.Checked)
            {
                drawings.deleteUseCase(tbUseCaseName.Text,UseCases);
            }
            if (rbEdit.Checked && rbUseCase.Checked)
            {
                drawings.saveUseCase(UseCases);
               
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

    }
}
