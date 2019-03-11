
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

        public Znamenitost()
        {

        }

        public Znamenitost(string naziv)
        {
            Naziv_Znamenitost = naziv;
        }

        public Znamenitost(string naziv_Znamenitost, TackastiObjekat id_Naseljenog_Mesta)
        {
            Naziv_Znamenitost = naziv_Znamenitost;
            Id_Naseljenog_Mesta = id_Naseljenog_Mesta;
        }

        public override string ToString()
        {
            return Id.ToString() + " " + Naziv_Znamenitost;
        }
    }
   
}
