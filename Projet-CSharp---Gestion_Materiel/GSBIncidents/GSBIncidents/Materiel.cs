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
<<<<<<< HEAD
            this.id_Materiel = id_Materiel;
            this.processus = processus;
            this.disque = disque;
            this.logiciel = logiciel;
            this.suivis = suivis;
            this.etat = etat;
=======
            this.id_materiel = Id_materiel;
            this.processus = Processus;
            this.disque = Disque;
            this.logiciel = Logiciel;
            this.suivis = Suivis;
            this.etat = Etat;
>>>>>>> 0a72b73fe316d2bde87ea451b6608a44bcae3d8b
        }

    }
}
