using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeografskaKartaNovo.Entiteti;

namespace GeografskaKartaNovo.DTOs
{
    public class KoordinateView
    {
        public virtual double X_lin { get; set; }
        public virtual double Y_lin { get; set; }
        public virtual int Id { get; set; }

        public virtual LinijskiObjekat Id_Linijskog_Objekta { get; set; }

        public KoordinateView()
        {

        }

        public override string ToString()
        {
            return Id.ToString() + " " + X_lin.ToString() + " " + Y_lin.ToString();
        }
    }
}
