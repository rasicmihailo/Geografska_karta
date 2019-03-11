using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using GeografskaKartaNovo.Entiteti;

namespace GeografskaKartaNovo.Mapiranja

{
    public class SadrziGeogMapiranje : ClassMap<SadrziGeog>
    {
        public SadrziGeogMapiranje()
        {

            Table("SADRZI_GEOG");

            Id(x => x.Id).Column("ID").GeneratedBy.TriggerIdentity();

            //Map(x => x.Id_Geografskog_Objekta).Column("ID1");
            //Map(x => x.Id_Uzvisenog_Objekta).Column("ID0");

            References(x => x.Id_Geografskog_Objekta).Column("ID1");
            References(x => x.Id_Uzvisenog_Objekta).Column("ID0");


        }
    }
}
