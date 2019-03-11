using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeografskaKartaNovo.Entiteti;

namespace GeografskaKartaNovo.DTOs
{
    public class UzvisenjeView
    {
        public virtual int Id { get; set; }
        public virtual String Naziv { get; set; }
        public virtual double Nadmorska_visina { get; set; }
        //public virtual IList<ListaVrhova> Lista_Vrhova { get; set; }

        //public virtual IList<SadrziGeog> Lista_SadrziGeog { get; set; }
        //public virtual IList<GeografskiObjekat> Lista_Geografskih_objekata { get; set; }

        public UzvisenjeView()
        {
            //    Lista_Vrhova = new List<ListaVrhova>();
            //    Lista_SadrziGeog = new List<SadrziGeog>();
            //    Lista_Geografskih_objekata = new List<GeografskiObjekat>();
        }
    }
}
