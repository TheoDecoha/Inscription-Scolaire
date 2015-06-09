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
    public partial class Inscription : Form
    {
      //  int cpt = 0;
        
        private ClassEleve UnEleve;
        private ArrayList lesEleves;
        

        public Inscription(ArrayList ListE)
        {
            InitializeComponent();
            lesEleves = ListE;
            tbnum.Text = ((lesEleves.Count) + 1).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (tbNom.Text != "" && tbprenom.Text != "" && dateTimePicker1.Text != "" && tbadresse1.Text != "" && tbville1.Text != "" && tbtel.Text != "" && tbclasse.Text != "" && tbcp1.Text != "" )
            {
                
                UnEleve = new ClassEleve(Convert.ToInt32(tbnum.Text), tbNom.Text, tbprenom.Text);
                UnEleve.Date = dateTimePicker1.Text;
                UnEleve.Adresse1 = tbadresse1.Text;
                UnEleve.Ville1 = tbville1.Text;
                UnEleve.Ville2 = tbville2.Text;
               
                UnEleve.Tel = tbtel.Text;
                UnEleve.Cp1 = tbcp1.Text;
                

               
                UnEleve.Classe = tbclasse.SelectedItem.ToString();
                lesEleves.Add(UnEleve);
                MessageBox.Show("Nombre d'élèves : " + lesEleves.Count.ToString());
              
                tbnum.Text = ((lesEleves.Count) + 1).ToString();
            }

            else
            {
                MessageBox.Show("Vous n'avez rien rentré !");
            }

            tbNom.Clear();
            tbprenom.Clear();
            tbadresse1.Clear();
            tbville1.Clear();
            tbadresse2.Clear();
            tbville2.Clear();
            tbtel.Clear();
            tbcp1.Clear();
            tbcp2.Clear();
          
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tbNom.Clear();
            tbprenom.Clear();
            tbadresse1.Clear();
            tbville1.Clear();
            tbadresse2.Clear();
            tbville2.Clear();
            tbtel.Clear();
            tbcp1.Clear();
            tbcp2.Clear();
           
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
        }

        private void tbcp1_TextChanged(object sender, CancelEventArgs e)
        {
            if (tbcp1.Text.Length != 5)
           
                MessageBox.Show("Code Postal incorrect !", "Erreur", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
                 e.Cancel = true;
            }

        

        //if (!char.IsControl(e.KeyChar) 
           // && char.IsDigit(e.KeyChar))
            //{
              //  MessageBox.Show("Erreur, vous devez saisir des lettres", "Erreur", MessageBoxButtons.OK,
                //MessageBoxIcon.Error);
               // e.Handled = true;
           // }

        }
}
