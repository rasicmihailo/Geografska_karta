using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeografskaKartaNovo.Entiteti
{
    public class TackastiObjekat : GeografskiObjekat
    {
        public virtual int X_tac { get; set; }
        public virtual int Y_tac { get; set; }
        public virtual DateTime Datum_Osnivanja { get; set; }
        public virtual int F_naseljeno { get; set; }
        public virtual int F_turisticko { get; set; }
        public virtual int Broj_Stanovnika { get; set; }
        public virtual String Tip_naselja { get; set; }
        public virtual String Opstina { get; set; }
        public virtual DateTime Datum_status { get; set; }
        public virtual String Tip_turizma { get; set; }

        public virtual IList<Znamenitost> Lista_Znamenitosti { get; set; }
        public virtual IList<SadrziTac> Lista_SadrziTac { get; set; }
        public virtual IList<LinijskiObjekat> Lista_Linijskih_objekata { get; set; }

        public TackastiObjekat()
        {
            Lista_Znamenitosti = new List<Znamenitost>();
            Lista_SadrziTac = new List<SadrziTac>();
            Lista_Linijskih_objekata = new List<LinijskiObjekat>();
        }

        public override string ToString()
        {
            return Id.ToString() + " " + Naziv;
        }
    }
}
