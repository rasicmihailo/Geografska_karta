using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeografskaKartaNovo.Entiteti
{
   public class SadrziLin
    {
        public virtual LinijskiObjekat Id_Linijskog_Objekta { get; set; }
        public virtual PovrsinskiObjekat Id_Povrsinskog_Objekta { get; set; }
        public virtual int Id { get; set; }

        public virtual IList<LinijskiObjekat> Lista_Linijski_Objekat { get; set; }
        public virtual IList<PovrsinskiObjekat> Lista_Povrsinski_Objekat { get; set; }

        public SadrziLin()
        {
            Lista_Linijski_Objekat = new List<LinijskiObjekat>();
            Lista_Povrsinski_Objekat = new List<PovrsinskiObjekat>();
        }

    }
}
