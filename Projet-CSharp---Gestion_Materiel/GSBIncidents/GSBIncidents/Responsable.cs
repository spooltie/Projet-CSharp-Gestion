using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSBIncidents
{
    internal class Responsable : Personnel
    {
        public int id_Responsable;

        public Responsable (int id_Responsable)
        {
            this.id_Responsable = id_Responsable;
        }
    }
}
