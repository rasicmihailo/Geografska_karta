using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using GeografskaKartaNovo.Entiteti;

namespace GeografskaKartaNovo.Mapiranja

{
    class ZnamenitostMapiranje : ClassMap<Znamenitost>
    {

        public ZnamenitostMapiranje()
        {

            Table("ZNAMENITOST");

            Id(x => x.Id).Column("ID").GeneratedBy.TriggerIdentity();


          
            Map(x => x.Naziv_Znamenitost).Column("ZNAMENITOST");

            References(x => x.Id_Naseljenog_Mesta).Column("ID_NASELJENOG_MESTA").Not.LazyLoad();
        }
    }
    

    

    
}
