using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSBIncidents
{
    internal class Personnel
    {
        public int Id;
        public String Nom;
        public String Prenom;
        public int Date_Embauche;
        public String Fonction;
        public String Login;
        public String MDP;
        public String Poste;

        public Personnel(int id, String nom, String prenom, int date_embauche, String fonction, String login, String mdp, String poste)
        {
            this.Id = id;
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
