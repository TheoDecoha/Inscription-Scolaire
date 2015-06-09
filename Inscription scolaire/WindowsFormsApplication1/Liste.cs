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
    public partial class Liste : Form
    {


        private ArrayList lesEleves;

        public Liste(ArrayList ListE)
        {
            InitializeComponent();
            lesEleves = ListE;
        }

        public MySqlDataAdapter mySqlDataAdapter1 = new MySqlDataAdapter();
        public MySqlCommandBuilder mySqlCommand1;
        public DataTable mySqlDataTable1 = new DataTable();


        private void cbliste1_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (ClassEleve E in lesEleves)
            {
                string eleve = E.Classe;



            }
        }

         public void charger()
        {
            if (!ClassEleve.connopen) return;
            mySqlDataAdapter1.SelectCommand = new MySqlCommand("select * from eleve;", ClassEleve.myConnection);
            MySqlCommandBuilder mySqlCommand1 = new MySqlCommandBuilder(mySqlDataAdapter1);
            try
            {
                mySqlDataTable1.Clear();
                mySqlDataAdapter1.Fill(mySqlDataTable1);
                
            }
            catch (Exception err)
            {
                MessageBox.Show("Erreur chargement dataset : " + err, "PBS table CATEGORIE",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                ClassEleve.errgrave = true;
            }
        }

        private void Liste_Load(object sender, EventArgs e)
         {


             charger();
             {
                 dataGridView1.DataSource = mySqlDataTable1;
             }

         }

        private void boutonQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }
            
        }

    }

