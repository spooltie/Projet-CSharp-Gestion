using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSBIncidents
{
    internal class Utilisateur : Personnel
    {
        public int id_User;
        public Utilisateur(int id_User, Personnel p)
            : base(p.id_Personnel, p.nom, p.prenom, p.date_Embauche, p.fonction, p.login, p.MDP, p.poste)
        {
            this.id_User = id_User;
        }
    }
}
