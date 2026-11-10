using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSBIncidents
{
    internal class Technicien
    {
        public int id_Tech;
        public string formation;
        public string competence;

        
        public Technicien(int id_Tech, string Formation, string Competence)
        {
            this.id_Tech = id_Tech;
            this.formation = Formation;
            this.competence = Competence;

        }

    }
    
    
}
