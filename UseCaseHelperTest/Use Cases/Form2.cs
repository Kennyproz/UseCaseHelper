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
        public Form2()
        {
            InitializeComponent();
        }
        public UseCase Case;

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Case = new UseCase(tbNaam.Text, tbSamenvatting.Text, tbAannamen.Text, tbBeschrijving.Text, tbUitzonderingen.Text, tbResultaat.Text);
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {
          
        }

        private void cbActoren_SelectedIndexChanged(object sender, EventArgs e)
        {
          //  lbActoren.Items.Add(cbActoren.SelectedIndex as Actors);
        }
        public ComboBox CbActoren
        {
            get { return cbActoren; }
        }
     
    }
}
