using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeografskaKartaNovo.Entiteti
{
   public class SadrziTac
    {
        public virtual LinijskiObjekat Id_Linijskog_Objekta { get; set; }
        public virtual TackastiObjekat Id_Tackastog_Objekta { get; set; }
        public virtual int Id { get; set; }

        public virtual IList<LinijskiObjekat> Lista_Linijski_Objekat { get; set; }
        public virtual IList<TackastiObjekat> Lista_Tackasti_Objekat { get; set; }

        public SadrziTac()
        {
            Lista_Linijski_Objekat = new List<LinijskiObjekat>();
            Lista_Tackasti_Objekat = new List<TackastiObjekat>();
        }

   //     public override string ToString()
   //     {
    //        return Id.ToString();
    //    }
    }
}
