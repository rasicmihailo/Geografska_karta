using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeografskaKartaNovo.Entiteti
{
    public class LinijskiObjekat : GeografskiObjekat
    {
        public virtual String Duzina { get; set; }
        public virtual String Tip_Objekta { get; set; }
        public virtual String Opis_Objekta { get; set; }

        public virtual IList<Koordinate> ListaKoordinata { get; set; }
        public virtual IList<SadrziTac> Lista_SadrziTac { get; set; }
        public virtual IList<SadrziLin> Lista_SadrziLin { get; set; }
        public virtual IList<TackastiObjekat> Lista_Tackastih_objekata { get; set; }
        public virtual IList<PovrsinskiObjekat> Lista_Povrsinskih_objekata { get; set; }

        public LinijskiObjekat()
        {
            ListaKoordinata = new List<Koordinate>();
            Lista_SadrziTac = new List<SadrziTac>();
            Lista_SadrziLin = new List<SadrziLin>();
            Lista_Tackastih_objekata = new List<TackastiObjekat>();
            Lista_Povrsinskih_objekata = new List<PovrsinskiObjekat>();
        }
        public override string ToString()
        {
            return Id.ToString() + " " + Naziv;
        }

    }
}
