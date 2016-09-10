using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Use_Cases
{
    public class Actors
    {
        private string name;
        private PictureBox actorimage;
        private Label actorlabel;
        private int X;
        private int Y;
        private bool select = false;

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public PictureBox Actorimage
        {
            get
            {
                return actorimage;
            }

            set
            {
                actorimage = value;
            }
        }

        public Label Actorlabel
        {
            get
            {
                return actorlabel;
            }

            set
            {
                actorlabel = value;
            }
        }

        public int X1
        {
            get
            {
                return X;
            }

            set
            {
                X = value;
            }
        }

        public int Y1
        {
            get
            {
                return Y;
            }

            set
            {
                Y = value;
            }
        }

        public bool Select
        {
            get
            {
                return select;
            }

            set
            {
                select = value;
            }
        }

        public Actors(string name,Label actorlabel, PictureBox actorimage)
        {
            this.name = name;
            this.actorimage = actorimage;
            this.actorlabel = actorlabel;
            
        }
        public void AddActor(string name)
        {
            actorlabel.Text = name;
            actorimage.Show();    
        }
        public void RemoveActor()
        {
            actorlabel.Text = "";
            name = "";
            actorimage.Hide();
        }
        public override string ToString()
        {
            return name;
        }
    }
}
