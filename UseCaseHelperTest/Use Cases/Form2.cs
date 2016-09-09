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
            tbNaam.Text = Convert.ToString(Case.Naam);
            tbSamenvatting.Text = Case.Samenvatting;
            tbAannamen.Text = Case.Aannamen;
            tbBeschrijving.Text = Case.Beschrijving;
            tbUitzonderingen.Text = Case.Uitzondering  ;
            tbResultaat.Text = Case.Resultaat; 
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
  
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
        public TextBox TbSamenvatting
        {
            get { return tbSamenvatting; }
            set { tbSamenvatting = value; }
        }
        public TextBox TbAannamen
        {
            get { return tbAannamen; }
            set { tbAannamen = value; }
        }
        public TextBox TbBeschrijving
        {
            get { return tbBeschrijving; }
            set { tbBeschrijving = value; }
        }
        public TextBox TbResultaat
        {
            get { return tbResultaat; }
            set { tbResultaat = value; }
        }
        public TextBox TbUitzonderingen
        {
            get { return tbUitzonderingen; }
            set { tbUitzonderingen = value; }
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Case.Naam = tbNaam.Text;
            Case.Samenvatting = tbSamenvatting.Text;
            Case.Aannamen = tbAannamen.Text;
            Case.Beschrijving = tbBeschrijving.Text;
            Case.Uitzondering = tbUitzonderingen.Text;
            Case.Resultaat = tbResultaat.Text;
            e.Cancel = true;
            this.Hide();
            
       
        }
    }
}
