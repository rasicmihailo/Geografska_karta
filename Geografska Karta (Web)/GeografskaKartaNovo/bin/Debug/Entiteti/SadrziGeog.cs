using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeografskaKartaNovo.Entiteti
{
    public class SadrziGeog
    {
        public virtual Uzvisenje Id_Uzvisenog_Objekta { get; set; }
        public virtual GeografskiObjekat Id_Geografskog_Objekta { get; set; }
        public virtual int Id { get; set; }

        public virtual IList<Uzvisenje> Lista_Uzvisenje_Objekat { get; set; }
        public virtual IList<GeografskiObjekat> Lista_Geografski_Objekat { get; set; }

        public SadrziGeog()
        {
            Lista_Uzvisenje_Objekat = new List<Uzvisenje>();
            Lista_Geografski_Objekat = new List<GeografskiObjekat>();
        }

    }
}
