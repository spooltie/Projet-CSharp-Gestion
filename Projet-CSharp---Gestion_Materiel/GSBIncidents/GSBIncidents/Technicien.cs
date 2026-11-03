using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSBIncidents
{
    internal class Technicien
    {
        public Int id_tech;
        public String formation;
        public String competence;

        
        public Technicien(String id_tech, String formation, String competence)
        {
            this.Id_materiel = id_tech;
            this.Processus = formation;
            this.Disque = competence;

        }

    }
    
    
}
