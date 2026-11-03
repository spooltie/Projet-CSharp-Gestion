using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSBIncidents
{
    internal class Materiel
    {
        public Int id_materiel;
        public String processus;
        public String disque;
        public String logiciel;
        public String suivis;
        public String etat;
        
        public Materiel(String id_materiel, String processus, String disque, int logiciel, String suivis, String etat)
        {
            this.Id_materiel = id_materiel;
            this.Processus = processus;
            this.Disque = disque;
            this.Logiciel = logiciel;
            this.Suivis = suivis;
            this.Etat = etat;
        }

    }
}
