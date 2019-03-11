using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using GeografskaKartaNovo.Entiteti;

namespace GeografskaKartaNovo.Mapiranja
{
    public class SadrziTacMapiranje : ClassMap<SadrziTac>
    {
        public SadrziTacMapiranje()
        {

            Table("SADRZI_TAC");

            Id(x => x.Id).Column("ID").GeneratedBy.TriggerIdentity();

            //Map(x => x.Id_Linijskog_Objekta).Column("ID0");
            //Map(x => x.Id_Tackastog_Objekta).Column("ID1");

            References(x => x.Id_Linijskog_Objekta).Column("ID0");
            References(x => x.Id_Tackastog_Objekta).Column("ID1");

        }
    }
}
