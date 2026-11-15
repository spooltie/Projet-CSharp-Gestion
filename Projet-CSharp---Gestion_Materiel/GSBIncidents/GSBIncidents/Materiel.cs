using System;

namespace GSBIncidents
{
    internal class Materiel
    {
        public int id_Materiel;
        public string processus;
        public string disque;
        public string logiciel;
        public DateTime date_Ajout;
        public string etat;

        public Materiel(int id_Materiel, string processus, string disque, string logiciel, DateTime date_Ajout, string etat)
        {
            this.id_Materiel = id_Materiel;
            this.processus = processus;
            this.disque = disque;
            this.logiciel = logiciel;
            this.date_Ajout = date_Ajout;
            this.etat = etat;
        }

        public override string ToString()
        {
            return "#" + id_Materiel + " - " + processus;
        }
    }
}