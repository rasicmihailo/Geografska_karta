using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeografskaKartaNovo.Entiteti
{
    public class GeografskiObjekat
    {
        public virtual int Id { get; set; }
        public virtual string Naziv { get; set;}

        public virtual IList<SadrziGeog> Lista_Sadrzi_Geog { get; set; }
        public virtual IList<Uzvisenje> Lista_Uzvisenja { get; set; }

        public GeografskiObjekat()
        {
            Lista_Uzvisenja = new List<Uzvisenje>();
            Lista_Sadrzi_Geog = new List<SadrziGeog>();
        }

    }
}
