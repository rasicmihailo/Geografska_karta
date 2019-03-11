using GeografskaKartaNovo.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeografskaKartaNovo.DTOs
{
    public class VodnaPovrsinaView
    {
        public virtual int Id { get; set; }
        public virtual string Naziv { get; set; }
        public virtual String Tip_Vode { get; set; }

        public VodnaPovrsinaView()
        {
        }

        public VodnaPovrsinaView(VodnaPovrsina vod)
        {
            this.Id = vod.Id;
            this.Naziv = vod.Naziv;
            this.Tip_Vode = vod.Tip_Vode;
        }
    }
}
