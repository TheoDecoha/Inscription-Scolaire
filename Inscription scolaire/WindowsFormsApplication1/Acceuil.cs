using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using MySql.Data.MySqlClient;


namespace WindowsFormsApplication1
{
    public partial class Acceuil : Form
    {
        public MySqlDataAdapter mySqlDataAdapter1 = new MySqlDataAdapter();
        public MySqlCommandBuilder mySqlCommand1;
        public DataTable mySQLDataTable1 = new DataTable();
        private ArrayList lesEleves;

        public Acceuil()
        {
            InitializeComponent();
        }

        private void inscriptionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Inscription FenetreInscription = new Inscription(lesEleves);
            FenetreInscription.MdiParent = this; //this fait référence à la fenêtre courante
            FenetreInscription.Show();
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClassEleve.seconnecter();
            if (ClassEleve.connopen == false)
            {
                MessageBox.Show("Erreur dans la connexion");
            }
            else
            {
              
                charger("delete from eleve ;");
                
                charger("select * from ELEVE;");
                
                foreach (ClassEleve E in lesEleves)
                {
                    int codec = 1;
                    DataRow NouvLigne = mySQLDataTable1.NewRow();
                    NouvLigne["NumEleve"] = E.NumEleve;
                    NouvLigne["Nom"] = E.Nom;
                    NouvLigne["Prenom"] = E.Prenom;
                    NouvLigne["DateNaissance"] = E.Date;
                    NouvLigne["Adresse 1"] = E.Adresse1;
                    NouvLigne["Adresse 2"] = E.Adresse2;
                    NouvLigne["Ville 1"] = E.Ville1;
                    NouvLigne["Ville 2"] = E.Ville2;
                    NouvLigne["Tel"] = E.Tel;
                    NouvLigne["CP1"] = E.Cp1;
                    NouvLigne["CP2"] = E.Cp2;
                    if (E.Classe == "Petite section")
                        codec = 1;
                    if (E.Classe == "Moyenne section")
                        codec = 2;
                    if (E.Classe == "Grande section")
                        codec = 3;
                    if (E.Classe == "CP")
                        codec = 4;
                    if (E.Classe == "CE1")
                        codec = 5;
                    if (E.Classe == "CE2")
                        codec = 6;
                    if (E.Classe == "CM1")
                        codec = 7;
                    if (E.Classe == "CM2")
                        codec = 8;

                    NouvLigne["NumClasse"] = codec;
                    mySQLDataTable1.Rows.Add(NouvLigne);
                    mySqlDataAdapter1.Update(mySQLDataTable1);
                }
                ClassEleve.sedeconnecter();
            }

            Application.Exit();
        }

        private void modifierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Modification FenetreModification = new Modification(lesEleves);
            FenetreModification.MdiParent = this; 
            FenetreModification.Show();
        }

        private void accueil_Load(object sender, EventArgs e)
        {
            lesEleves = new ArrayList();

            ClassEleve.seconnecter();
        
            if (ClassEleve.connopen == false)
            {
            MessageBox.Show("Erreur dans la connexion");
            }
            
            else
            {
           
            
            charger("select * from ELEVE E, CLASSE C where E.NumClasse=C.NumClasse;");
            MessageBox.Show("BD connectée ");
           
           
           
            ClassEleve UnEleve;
            for (int i = 0; i < mySQLDataTable1.Rows.Count; i++)
            {
               
              
                UnEleve = new ClassEleve(Convert.ToInt32(mySQLDataTable1.Rows[i]["NumEleve"]),
                mySQLDataTable1.Rows[i]["Nom"].ToString(),
                mySQLDataTable1.Rows[i]["Prenom"].ToString());
                
                UnEleve.Date = mySQLDataTable1.Rows[i]["DateNaissance"].ToString();
                UnEleve.Adresse1 = mySQLDataTable1.Rows[i]["Adresse 1"].ToString();
                UnEleve.Adresse2 = mySQLDataTable1.Rows[i]["Adresse 2"].ToString();
                UnEleve.Ville1 = mySQLDataTable1.Rows[i]["Ville 1"].ToString();
                UnEleve.Ville2 = mySQLDataTable1.Rows[i]["Ville 2"].ToString();
                UnEleve.Tel = mySQLDataTable1.Rows[i]["Tel"].ToString(); 
                UnEleve.Classe = mySQLDataTable1.Rows[i]["Classe"].ToString();
                UnEleve.Cp1 = mySQLDataTable1.Rows[i]["CP1"].ToString();
                UnEleve.Cp2 = mySQLDataTable1.Rows[i]["CP2"].ToString();
                lesEleves.Add(UnEleve);
            }
           
            ClassEleve.sedeconnecter();
            }

        }

        public void charger (string requete)
        {
        if (!ClassEleve.connopen) return; 
        mySqlDataAdapter1.SelectCommand = new MySqlCommand(requete, ClassEleve.myConnection);
        MySqlCommandBuilder mySqlCommand1 = new MySqlCommandBuilder(mySqlDataAdapter1);
        try
        {
        mySQLDataTable1.Clear();
        mySqlDataAdapter1.Fill(mySQLDataTable1);
        }
        catch (Exception err)
        {
        MessageBox.Show("Erreur chargement dataset : " + err, "PBS table",
        MessageBoxButtons.OK, MessageBoxIcon.Error);
        ClassEleve.errgrave = true;
        }
        }

        private void listeddesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Liste FenetreModification = new Liste(lesEleves);
            FenetreModification.MdiParent = this;
            FenetreModification.Show();
        }

        
    }
}
