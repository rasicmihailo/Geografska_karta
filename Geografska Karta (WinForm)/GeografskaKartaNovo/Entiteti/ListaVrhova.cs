using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeografskaKartaNovo.Entiteti
{
    public class ListaVrhova
    {
        public virtual String Ime { get; set; }
        public virtual double Nadmorska_visina { get; set; }
        public virtual int Id { get; set; }
        public virtual Uzvisenje Id_Uzvisenja { get; set; }

        public override string ToString()
        {
            return Id.ToString() + " " + Ime;
        }
    }
}
