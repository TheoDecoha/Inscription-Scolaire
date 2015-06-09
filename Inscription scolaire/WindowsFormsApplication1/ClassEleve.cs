using System;
using System.Collections.Generic;
using System.Linq;
using MySql.Data.MySqlClient;
using System.Text;

namespace WindowsFormsApplication1
{
    class ClassEleve
    {
        public static MySqlConnection myConnection; // variable de connexion
        public static bool connopen = false; // pour tester si la connexion est ouverte
        public static bool errgrave = false; // pour tester si des erreurs se sont produites

        #region propriétés privées
        //propriétés privées
        private int numEleve;
        private string nom;
        private string prenom;
        private string date;
        private string adresse1;
        private string adresse2;
        private string ville1;
        private string ville2;
        private string tel;
        private string classe;
        private string cp1;
        private string cp2;

       

       
        
        #endregion

        #region accesseurs publics
        //accesseurs publics
       public int NumEleve
        {
            get { return numEleve; }
          
        } 
        public string Nom
        {
            get { return nom; }
            set { nom = value; }
        }

        public string Prenom
        {
            get { return prenom; }
            set { prenom = value; }
        }

        public string Date
        {
            get { return date; }
            set { date = value; }
        }

        public string Adresse1
        {
            get { return adresse1; }
            set { adresse1 = value; }
        }

        public string Adresse2
        {
            get { return adresse2; }
            set { adresse2 = value; }
        }
        public string Ville1
        {
            get { return ville1; }
            set { ville1 = value; }
        }

        public string Ville2
        {
            get { return ville2; }
            set { ville2 = value; }
        }

        public string Tel
        {
            get { return tel; }
            set { tel = value; }
        }

        public string Classe
        {
            get { return classe; }
            set { classe = value; }
        }

        public string Cp1
        {
            get { return cp1; }
            set { cp1 = value; }
        }

        public string Cp2
        {
            get { return cp2; }
            set { cp2 = value; }
        }

      
        #endregion 

        #region constructeur 
        //constructeur 
        public ClassEleve(int num, string n, string p)
        {
            numEleve = num;
            nom = n;
            prenom = p;
        }

        public ClassEleve(int num, string n, string p, string d, string adr1, string adr2, string vil1, string vil2, string t, string c,string c1, string c2)
        {
            numEleve = num;
            nom = n;
            prenom = p;
            date = d;
            adresse1 = adr1;
            adresse2 = adr2;
            ville1 = vil1;
            ville2 = vil2;
            tel = t;
            classe = c;
            cp1 = c1;
            cp2 = c2;

          
        }
        #endregion


        public static void seconnecter()
        {
            string myConnectionString = "Database=bd_scolaire;Data Source=localhost;User Id=root;";
            myConnection = new MySqlConnection(myConnectionString);
            connopen = true;
            try // tentative
            {
                myConnection.Open(); // ouverture de la connexion
            }
            catch (Exception err)// gestion des erreurs
            {
                connopen = false; errgrave = true;
            }
        }
        public static void sedeconnecter()
        {
            if (!connopen) return; // pour tester si la connexion est bien ouverte
            try
            {
                myConnection.Close(); // fermeture de la connexion
                myConnection.Dispose(); // libération de la connexion
            }
            catch (Exception err)
            {
                errgrave = true;
            }
        }
    }
}
