using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeografskaKartaNovo.Entiteti;

namespace GeografskaKartaNovo.DTOs
{
    public class ListaVrhovaView
    {
        public virtual String Ime { get; set; }
        public virtual double Nadmorska_visina { get; set; }
        public virtual int Id { get; set; }

        public ListaVrhovaView()
        {

        }

    }
}
