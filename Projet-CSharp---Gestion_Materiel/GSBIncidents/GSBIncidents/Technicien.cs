using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSBIncidents
{
    internal class Technicien
    {
        public int id_tech;
        public String formation;
        public String competence;

        
        public Technicien(String Id_tech, String Formation, String Competence)
        {
            this.Id_materiel = Id_tech;
            this.Processus = Formation;
            this.Disque = Competence;

        }

    }
    
    
}
