using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeografskaKartaNovo.Entiteti
{
    public class PovrsinskiObjekat : GeografskiObjekat
    {
       public virtual IList<SadrziLin> Lista_SadrziLin { get; set; }
       public virtual IList<LinijskiObjekat> Lista_Linijskih_objekata { get; set; }

        public PovrsinskiObjekat()
        {
            Lista_SadrziLin = new List<SadrziLin>();
            Lista_Linijskih_objekata = new List<LinijskiObjekat>();
        }

    }
    public class Uzvisenje : PovrsinskiObjekat
    {
        public virtual double Nadmorska_visina { get; set; }
        public virtual IList<ListaVrhova> Lista_Vrhova { get; set; }

        public virtual IList<SadrziGeog> Lista_SadrziGeog { get; set; }
        public virtual IList<GeografskiObjekat> Lista_Geografskih_objekata { get; set; }

        public Uzvisenje()
        {
            Lista_Vrhova = new List<ListaVrhova>();
            Lista_SadrziGeog = new List<SadrziGeog>();
            Lista_Geografskih_objekata = new List<GeografskiObjekat>();
        }
        public override string ToString()
        {
            return Id.ToString() + " " + Naziv + " " + Nadmorska_visina.ToString() ;
        }
    }
    public class VodnaPovrsina : PovrsinskiObjekat
    {
        public virtual String Tip_Vode { get; set; }

    }
}
