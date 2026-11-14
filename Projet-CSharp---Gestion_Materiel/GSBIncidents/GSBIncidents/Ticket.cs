using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSBIncidents
{
    internal class Ticket
    {
        public int id_Ticket;
        public string incident;
        public string etat;
        public string niveau_Urgence;
        public string suivi;

        public int id_Materiel;
        public int id_Personnel;

        public Ticket(int id_Ticket, string incident, string etat, string niveau_Urgence, string suivi)
        {
            this.id_Ticket = id_Ticket;
            this.incident = incident;
            this.etat = etat;
            this.niveau_Urgence = niveau_Urgence;
            this.suivi = suivi;
        }
        public override string ToString()
        {
            return "Ticket n°" + id_Ticket + " - " + incident + " [" + etat + " / " + niveau_Urgence + "]";
        }
    }

}