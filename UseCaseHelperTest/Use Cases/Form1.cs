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
    public partial class  Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            hideActors();
        }
        Graphics g;
        Pen MyPen = new Pen(Color.Black, 4);
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            g.Clear(Color.White);
            hideActors();

        }
        private void hideActors()
        {
            pbActorOne.Hide();
            pbActorTwo.Hide();
            pbActorThree.Hide();
            lbActorOne.Text = "";
            lbActorTwo.Text = "";
            lbActorThree.Text = "";
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
                        pbActorOne.Show();
                        lbActorOne.Text = tbActorName.Text;
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
                        pbActorTwo.Show();
                        lbActorTwo.Text = tbActorName.Text;
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
                        pbActorThree.Show();
                        lbActorThree.Text = tbActorName.Text;
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
                if (pbActorThree.Visible == true)
                {
                    pbActorThree.Hide();
                    lbActorThree.Text = "";
                }
                else if (pbActorTwo.Visible == true)
                {
                    pbActorTwo.Hide();
                    lbActorTwo.Text = "";
                }
                else if (pbActorOne.Visible == true)
                {
                    pbActorOne.Hide();
                    lbActorOne.Text = "";
                }
                else
                {
                    MessageBox.Show("No Actors to remove!");
                }
            }
        }
        
        private void addForms()
        {   
                Form newFormulier = new Form2();
                newFormulier.ShowDialog();
        }

        private void pbTeken_MouseClick(object sender, MouseEventArgs e)
        {
            g = pbTeken.CreateGraphics();
            addRemoveActors();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btNewForm_Click(object sender, EventArgs e)
        {
            addForms();
        }
    }
}
