using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mysql.Data.MySqlClient;

namespace GSBIncidents
{
    internal class Personnel
    {
        public int Id_personnel;
        public String Nom;
        public String Prenom;
        public int Date_Embauche;
        public String Fonction;
        public String Login;
        public String MDP;
        public String Poste;

<<<<<<< HEAD
        public Personnel(int id, String nom, String prenom, int date_embauche, String fonction, String login, String mdp, String poste)
=======
        public Personnel( int Id_personnel, String nom, String prenom, int date_embauche, String fonction, String login, String mdp, String poste)
>>>>>>> da59d1966362755e5dd918db4620ce0708921a6f
        {
            this.Id_personnel = Id_personnel;
            this.Nom = nom;
            this.Prenom = prenom;
            this.Date_Embauche = date_embauche;
            this.Fonction = fonction;
            this.Login = login;
            this.MDP = mdp;
            this.Poste = poste;
        }

       
    }
}
