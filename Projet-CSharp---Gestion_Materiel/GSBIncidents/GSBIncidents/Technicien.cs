using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSBIncidents
{
    internal class Technicien : Personnel
    {
        public int id_Tech;
        public int niveau;
        public string formation;
        public string competence;

        public Technicien(int id_Tech, string Formation, string Competence, Personnel p)
            : this(id_Tech, 1, Formation, Competence, p)
        {
        }

        public Technicien(int id_Tech, int niveau, string Formation, string Competence, Personnel p)
            : base(p.id_Personnel, p.nom, p.prenom, p.date_Embauche, p.fonction, p.login, p.MDP, p.poste)
        {
            this.id_Tech = id_Tech;
            this.niveau = niveau;
            this.formation = Formation;
            this.competence = Competence;
        }

    }
}