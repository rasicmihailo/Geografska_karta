using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using GeografskaKartaNovo.Entiteti;

namespace GeografskaKartaNovo.Mapiranja

{
    public class SadrziLinMapiranje : ClassMap<SadrziLin>
    {
        public SadrziLinMapiranje()
        {

            Table("SADRZI_LIN");

            Id(x => x.Id).Column("ID").GeneratedBy.TriggerIdentity();

            //Map(x => x.Id_Linijskog_Objekta).Column("ID1");
            //Map(x => x.Id_Povrsinskog_Objekta).Column("ID0");

            References(x => x.Id_Linijskog_Objekta).Column("ID1");
            References(x => x.Id_Povrsinskog_Objekta).Column("ID0");

        }
    }
}
