using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace GSBIncidents
{
    internal class Personnel
    {
        public int id_Personnel;
        public string nom;
        public string prenom;
        public int date_Embauche;
        public string fonction;
        public string login;
        public string MDP;
       public string poste;


        public Personnel( int id_Personnel, string nom, string prenom, int date_embauche, string fonction, string login, string mdp, string poste)

        {
            this.id_Personnel = id_Personnel;
            this.nom = nom;
            this.prenom = prenom;
            this.date_Embauche = date_embauche;
            this.fonction = fonction;
            this.login = login;
            this.MDP = mdp;
            this.poste = poste;
        }

       
    }
}
