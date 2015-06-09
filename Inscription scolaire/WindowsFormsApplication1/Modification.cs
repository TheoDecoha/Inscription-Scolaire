using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace WindowsFormsApplication1
{
    public partial class Modification : Form
    {
        private int nbE;
        
        private ArrayList lesEleves;

        public Modification(ArrayList ListE)
        {
            InitializeComponent();
            lesEleves = ListE;
            nbE = lesEleves.Count;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (ClassEleve E in lesEleves)
            {
                string eleve = E.NumEleve + "-" + E.Nom + "-" + E.Prenom;
                if (eleve == cbliste.SelectedItem.ToString())
                {
                    
                    tbnum.Text = E.NumEleve.ToString();
                    tbnom.Text = E.Nom;
                    tbprenom.Text = E.Prenom;
                    cbliste.SelectedItem = E.Classe;
                    dateTimePicker1.Text = E.Date;
                    tbadresse1.Text = E.Adresse1;
                    tbville1.Text = E.Ville1;
                    tbtel.Text = E.Tel;
                    tbadresse2.Text = E.Adresse2;
                    tbville2.Text = E.Ville2;
                    tbcp1.Text = E.Cp1;
                    tbcp2.Text = E.Cp2;

                }
            }
        }

        private void Modification_Load(object sender, EventArgs e)
        {   
           
            if (lesEleves.Count == 0)
                cbliste.Items.Add("Aucun élève enregistré");
            else
            {
                foreach (ClassEleve E in lesEleves)
                {
                    cbliste.Items.Add(E.NumEleve + "-" + E.Nom + "-" + E.Prenom);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

       



        
    }
}
