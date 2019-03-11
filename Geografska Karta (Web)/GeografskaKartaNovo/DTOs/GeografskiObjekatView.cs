using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeografskaKartaNovo.Entiteti;


namespace GeografskaKartaNovo.DTOs
{
    public class GeografskiObjekatView
    {
        public virtual int Id { get; set; }
        public virtual string Naziv { get; set; }

        //public virtual IList<SadrziGeog> Lista_Sadrzi_Geog { get; set; }
        //public virtual IList<Uzvisenje> Lista_Uzvisenja { get; set; }

        public GeografskiObjekatView()
        {
            //Lista_Uzvisenja = new List<Uzvisenje>();
            //Lista_Sadrzi_Geog = new List<SadrziGeog>();
        }

    }
}
