using GeografskaKartaNovo.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeografskaKartaNovo.DTOs
{
    public class PovrsinskiObjekatView
    {
        public virtual int Id { get; set; }
        public virtual string Naziv { get; set; }

        //public virtual IList<SadrziLin> Lista_SadrziLin { get; set; }
        //public virtual IList<LinijskiObjekat> Lista_Linijskih_objekata { get; set; }

        public PovrsinskiObjekatView()
        {
        }

        public PovrsinskiObjekatView(PovrsinskiObjekat pov)
        {
            this.Id = pov.Id;
            this.Naziv = pov.Naziv;

            //Lista_SadrziLin = new List<SadrziLin>();
            //Lista_Linijskih_objekata = new List<LinijskiObjekat>();
        }
    }
}
