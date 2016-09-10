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
    public partial class Form2 : Form
    {
        public UseCase Case;

        public Form2(string naam)
        {
            InitializeComponent();
            Case = new UseCase(naam);
        }
        public Form2(UseCase Case)
        {
            InitializeComponent();
            this.Case = Case;
            //Returning the Case Information
            Case.Select = true;
            tbNaam.Text = Convert.ToString(Case.Naam);
            tbSamenvatting.Text = Case.Samenvatting;
            tbAannamen.Text = Case.Aannamen;
            tbBeschrijving.Text = Case.Beschrijving;
            tbUitzonderingen.Text = Case.Uitzondering  ;
            tbResultaat.Text = Case.Resultaat;
            
            if (Case.Actors != null)
            {
       
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }

        private void cbActoren_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Adding Actors to Listbox
            if (cbActoren.SelectedItem != null)
            {
                if (lbActoren.Items.Contains((Actors)cbActoren.SelectedItem) == false)
                {
                    lbActoren.Items.Add((Actors)cbActoren.SelectedItem);
                    lbActoren.Refresh();
                }
                else if (lbActoren.Items.Contains((Actors)cbActoren.SelectedItem))
                {
                    lbActoren.Items.Remove(cbActoren.SelectedItem);
                    ((Actors)cbActoren.SelectedItem).Select = false;
                    return;
                    //MessageBox.Show("Actor already added!");
                }
            }
            else if (lbActoren.Items.Count == 0)
            {
                MessageBox.Show("No Actor selected!");
            }
        }
        public ComboBox CbActoren
        {
            get { return cbActoren; }
            set { cbActoren = value; }
        }
        public TextBox TbNaam
        {
            get { return tbNaam;  }
            set { tbNaam = value; }
        }

        public ListBox listbActoren
        {
            get { return lbActoren; }
            set { lbActoren = value; }
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Saving the Case 
            Case.Naam = tbNaam.Text;
            Case.Samenvatting = tbSamenvatting.Text;
            Case.Aannamen = tbAannamen.Text;
            Case.Beschrijving = tbBeschrijving.Text;
            Case.Uitzondering = tbUitzonderingen.Text;
            Case.Resultaat = tbResultaat.Text;
            foreach (Actors actor in lbActoren.Items)
            {
                actor.Select = true;
                Case.Actors.Add(actor);
            }
            Case.Select = false;
            e.Cancel = true;
            this.Hide();
        }

        private void lbActoren_SelectedValueChanged(object sender, EventArgs e)
        {
            lbActoren.ClearSelected();
            //lbActoren.Items.Remove(lbActoren.SelectedValue);
        //    if (Case.Actors != null)
        //    {
        //    foreach (Actors actor in Case.Actors)
        //    {
        //        if (lbActoren.SelectedItem.Equals(actor))
        //        {
        //            Case.Actors.Remove(actor);
        //        }
        //    }
        //}
        //    else
        //    {
        //        return;
        //    }
        }
    }
}
