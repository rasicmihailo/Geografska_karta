
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeografskaKartaNovo.Entiteti

{
    public class Znamenitost
    {
        public virtual String Naziv_Znamenitost { get; set; }
        public virtual int Id { get; set; }
        public virtual TackastiObjekat Id_Naseljenog_Mesta { get; set; }

        public override string ToString()
        {
            return Id.ToString() + " " + Naziv_Znamenitost;
        }
    }
   
}
