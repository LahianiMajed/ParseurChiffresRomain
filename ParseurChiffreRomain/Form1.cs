using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ParseurRomain;

namespace ParseurChiffreRomain
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnConvertisseur_Click(object sender, EventArgs e)
        {
           // string result = "string.Empty";
            ParseurRomain.ParseurChiffreRomain parseurChiffreRomain = new ParseurRomain.ParseurChiffreRomain();

            //this.textChiffreRomain
            int result = parseurChiffreRomain.ParseurChiffreRomainEntier(this.textChiffreRomain.Text);

            if (result == 0)
            {
                this.resultat.Text = "ERREUR chiffre romain";
            }
            else
            {

                this.resultat.Text = result.ToString();
            }

        }
    }
}
