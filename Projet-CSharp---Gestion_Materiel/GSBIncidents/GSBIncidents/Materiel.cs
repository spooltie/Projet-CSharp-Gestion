using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSBIncidents
{
    internal class Materiel
    {
        public int id_Materiel;
        public string processus;
        public string disque;
        public string logiciel;
        public string suivis;
        public string etat;
        
        public Materiel(int id_Materiel, string processus, string disque, string logiciel, string suivis, string etat)
        {
            this.id_Materiel = id_Materiel;
            this.processus = processus;
            this.disque = disque;
            this.logiciel = logiciel;
            this.suivis = suivis;
            this.etat = etat;
        }

    }
}
