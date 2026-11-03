using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSBIncidents
{
    internal class Technicien
    {
        public int Id_tech;
        public String Formation;
        public String Competence;

        
        public Technicien(int Id_tech, String Formation, String Competence)
        {
            this.Id_tech = Id_tech;
            this.Formation = Formation;
            this.Competence = Competence;

        }

    }
    
    
}
