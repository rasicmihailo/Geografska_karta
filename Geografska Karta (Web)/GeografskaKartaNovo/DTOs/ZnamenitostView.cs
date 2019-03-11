using GeografskaKartaNovo.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeografskaKartaNovo.DTOs
{
    public class ZnamenitostView
    {

        public virtual String Naziv_Znamenitost { get; set; }
        public virtual int Id { get; set; }
        public virtual TackastiObjekat Id_Naseljenog_Mesta { get; set; }

        public ZnamenitostView(Znamenitost z)
        {
            this.Naziv_Znamenitost = z.Naziv_Znamenitost;
            this.Id = z.Id;
            this.Id_Naseljenog_Mesta = z.Id_Naseljenog_Mesta;
        }


        public ZnamenitostView()
        {
        }


        public override string ToString()
        {
            return Id.ToString() + " " + Naziv_Znamenitost;
        }

    }
}
