using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSBIncidents
{
    internal class Ticket
    {
        public int ID_ticket;
        public String Incident;
        public String Etat;
        public String Niveau_urgence;
        public String Suivi;

        public Ticket(int ID_ticket, string Incident, string Etat, string Niveau_urgence, string Suivi)
        {
            this.ID_ticket = ID_ticket;
            this.Incident = Incident;
            this.Etat = Etat;
            this.Niveau_urgence = Niveau_urgence;
            this.Suivi = Suivi;
        }
    }
}
