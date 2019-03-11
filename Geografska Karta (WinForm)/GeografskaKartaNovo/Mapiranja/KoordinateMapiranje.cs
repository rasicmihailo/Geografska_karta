using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using GeografskaKartaNovo.Entiteti;


namespace GeografskaKartaNovo.Mapiranja
{
    public class KoordinateMapiranje : ClassMap<Koordinate>
    {
        public KoordinateMapiranje()
        {

            Table("KOORDINATE");

            Id(x => x.Id).Column("ID").GeneratedBy.TriggerIdentity();

           
            Map(x => x.X_lin).Column("X_LIN");
            Map(x => x.Y_lin).Column("Y_LIN");

            References(x => x.Id_Linijskog_Objekta).Column("ID_LINIJSKOG_OBJEKTA").Not.LazyLoad();
        }
    }
}
