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
           // lbActoren.Items.Add(Case.Actornaam1);
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            lbActoren.Items.Clear();
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
                    MessageBox.Show("Actor already added!");
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
                if (actor.Y1 <= 180)
                {
                    Case.Actornaam1 = true;
                    Case.Actor1 = actor.Name;
                }
                if (actor.Y1 >= 190 && actor.Y1 <= 465)
                {
                    Case.Actornaam2 = true;
                    Case.Actor2 = actor.Name;
                }
                if (actor.Y1 >= 469)
                {
                    Case.Actornaam3 = true;
                    Case.Actor3 = actor.Name;
                }
            }
            Case.Select = false;
            e.Cancel = true;
            this.Hide();
        }

        private void lbActoren_SelectedValueChanged(object sender, EventArgs e)
        {
            lbActoren.Items.Remove(lbActoren.SelectedItem);
        }
    }
}
