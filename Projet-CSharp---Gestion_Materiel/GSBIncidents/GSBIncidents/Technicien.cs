using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSBIncidents
{
    internal class Technicien : Personnel
    {
        public int id_Tech;
        public int niveau;
        public string formation;
        public string competence;

        public Technicien(int id_Tech, string Formation, string Competence)
            : this(id_Tech, 1, Formation, Competence)
        {
        }

        public Technicien(int id_Tech, int niveau, string Formation, string Competence)
        {
            this.id_Tech = id_Tech;
            this.niveau = niveau;
            this.formation = Formation;
            this.competence = Competence;
        }

        // Tickets: consulterTickets, prendreEnCharge, changerEtat, consignerSuivis)
        public List<Ticket> ConsulterTickets()
        {
            return BD.GetTicketsNonClotures();
        }

        /// <param name="unTicket">Ticket à prendre en charge.</param>
        public void PrendreEnCharge(Ticket unTicket)
        {
            BD.PriseEnChargeIncident(unTicket, this);
        }

        /// <param name="unTicket">Ticket à modifier.</param>
        /// <param name="etat">Nouvel état.</param>
        public void ChangerEtat(Ticket unTicket, string etat)
        {
            unTicket.etat = etat;
            BD.ModificationEtatIncident(unTicket);
        }

        /// <param name="unTicket">Ticket concerné.</param>
        /// <param name="suivi">Travail réalisé.</param>
        public void ConsignerSuivis(Ticket unTicket, string suivi)
        {
            unTicket.suivi = suivi;
            BD.ModificationTicket(unTicket);
        }

        // Matériel (onglet Technicien)

        public void AjouterMateriel(Materiel unMateriel)
        {
            BD.AjouteMateriel(unMateriel);
        }

        public List<Materiel> ConsulterMateriels()
        {
            return BD.GetMateriels();
        }

        public void SupprimerMateriel(Materiel unMateriel)
        {
            BD.DeleteMateriel(unMateriel);
        }
    }
}