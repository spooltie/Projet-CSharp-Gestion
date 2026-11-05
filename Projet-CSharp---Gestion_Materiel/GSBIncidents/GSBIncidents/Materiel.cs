using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSBIncidents
{
    internal class Materiel
    {
        public int id_materiel;
        public String processus;
        public String disque;
        public String logiciel;
        public String suivis;
        public String etat;
        
        public Materiel(String Id_materiel, String Processus, String Disque, int Logiciel, String Suivis, String Etat)
        {
            this.id_materiel = Id_materiel;
            this.processus = Processus;
            this.disque = Disque;
            this.logiciel = Logiciel;
            this.suivis = Suivis;
            this.etat = Etat;
        }

    }
}
