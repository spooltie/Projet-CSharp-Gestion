using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSBIncidents
{
    internal class Materiel
    {
        public int Id_materiel;
        public String Processus;
        public String Disque;
        public String Logiciel;
        public String Suivis;
        public String Etat;
        
        public Materiel(int Id_materiel, String Processus, String Disque, String Logiciel, String Suivis, String Etat)
        {
            this.Id_materiel = Id_materiel;
            this.Processus = Processus;
            this.Disque = Disque;
            this.Logiciel = Logiciel;
            this.Suivis = Suivis;
            this.Etat = Etat;
        }

    }
}
