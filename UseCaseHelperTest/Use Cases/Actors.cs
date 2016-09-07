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
           // actorlabel.Show();
             
        }
        public void RemoveActor()
        {
            actorlabel.Text = "";
            //actorimage.Name = "";
            name = "";
            actorimage.Hide();


        }
    }
}
