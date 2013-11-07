using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOGSM
{
    public partial class Form1 : Form
    {
        private Enquete enquete = new Enquete(2);        

        public Form1()
        {
            InitializeComponent();            
        }

        private void btnDeelnemers_Click(object sender, EventArgs e)
        {
            // stelt het aantal deelnemers in
            // bij geldig aantal, verander de UI
            try
            {                
                Int16 deelnemers = Int16.Parse(txtAantal.Text);
                if (deelnemers < 1)
                    throw new OverflowException();

                enquete.AantalDeelnemers = deelnemers;

                WisselUI();
            }
            catch (FormatException)
            {
                Foutmelding("U gaf geen getal in, gelieve een getal in te geven.");
            }
            catch (OverflowException)
            {
                Foutmelding("Het getal dat u ingegeven hebt is te groot of te klein.");
            }
        }

        private void Foutmelding(String boodschap)
        {
            // geeft een foutmelding weer voor het aantal deelnemers en plaats opnieuw de focus in die textbox
            MessageBox.Show(boodschap);
            txtAantal.Text = "";
            txtAantal.Focus();
        }

        private void btnAntwoorden_Click(object sender, EventArgs e)
        {
            // geeft de 2 antwoorden door aan VerwerkResultaat()
            // bij false als resultaat stopt de enquete
            if (!enquete.VerwerkResultaat(new String[] { txtVraag1.Text, txtVraag2.Text }))
            {         
                btnAntwoorden.Enabled = false;
                txtVraag1.Enabled = false;
                txtVraag2.Enabled = false;
            }
            else
            {                
                txtVraag1.Text = "";
                txtVraag2.Text = "";                
            }
            
            // weergeven resultaten
            lblResultaat1.Text = "Vraag 1: \n" + enquete.Vragen[0].Resultaat();
            lblResultaat2.Text = "Vraag 2: \n" + enquete.Vragen[1].Resultaat();
            lblGsmgebruik.Text = enquete.Vragen[1].GsmGebruik();
        }

        private void btnEinde_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            // voert een volledige reset uit van de UI en maakt een nieuw Enquete object aan (het oude vervalt)
            enquete = new Enquete(2);

            WisselUI();

            foreach (Control c in new Control[] { txtAantal, txtVraag1, txtVraag2, lblResultaat1, lblResultaat2, lblGsmgebruik })
                c.Text = "";   
        }        

        private void WisselUI()
        {
            // verandert de Enabled property van een aantal buttos en textboxen
            foreach (Control c in new Control[] { btnDeelnemers, btnAntwoorden, txtAantal, txtVraag1, txtVraag2 })
                c.Enabled = !c.Enabled;
        }

    }
}
