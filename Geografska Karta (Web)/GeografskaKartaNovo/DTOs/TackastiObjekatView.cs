using GeografskaKartaNovo.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeografskaKartaNovo.DTOs
{
    public class TackastiObjekatView
    {
        public virtual int Id { get; set; }
        public virtual string Naziv { get; set; }
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

        //public virtual IList<Znamenitost> Lista_Znamenitosti { get; set; }
        //public virtual IList<SadrziTac> Lista_SadrziTac { get; set; }
        //public virtual IList<LinijskiObjekat> Lista_Linijskih_objekata { get; set; }

        public TackastiObjekatView()
        {
        }
  
        public TackastiObjekatView(TackastiObjekat tac)
        {
            this.Id = tac.Id;
            this.Naziv = tac.Naziv;
            this.X_tac = tac.X_tac;
            this.Y_tac = tac.Y_tac;
            this.Datum_Osnivanja = tac.Datum_Osnivanja;
            this.F_naseljeno = tac.F_naseljeno;
            this.F_turisticko = tac.F_turisticko;
            this.Broj_Stanovnika = tac.Broj_Stanovnika;
            this.Tip_naselja = tac.Tip_naselja;
            this.Opstina = tac.Opstina;
            this.Datum_status = tac.Datum_status;
            this.Tip_turizma = tac.Tip_turizma;

            //this.Lista_Znamenitosti = new List<Znamenitost>();
            //this.Lista_SadrziTac = new List<SadrziTac>();
            //this.Lista_Linijskih_objekata = new List<LinijskiObjekat>();

        }

        public override string ToString()
        {
            return Id.ToString() + " " + Naziv;
        }
    }
}
