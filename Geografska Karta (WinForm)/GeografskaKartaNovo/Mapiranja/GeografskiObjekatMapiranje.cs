using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using GeografskaKartaNovo.Entiteti;

namespace GeografskaKartaNovo.Mapiranja
{
    public class GeografskiObjekatMapiranje : ClassMap<GeografskiObjekat>
    {
        public GeografskiObjekatMapiranje()
        {
            Table("GEOGRAFSKI_OBJEKAT");

            Id(x => x.Id).Column("ID").GeneratedBy.SequenceIdentity("S15850.GEOGRAFSKI_OBJEKAT_ID_SEQ");
            Map(x => x.Naziv).Column("NAZIV");

            //veza  N:M Geografski - Uzvisenje
            //HasManyToMany(x => x.Lista_Sadrzi_Geog)
            //    .Table("SADRZI_GEOG")
            //    .ParentKeyColumn("ID1")
            //    .ChildKeyColumn("ID0")
            //    .Inverse()
            //    .Cascade.All();

            HasMany(x => x.Lista_Sadrzi_Geog).KeyColumn("ID1").Cascade.All().Inverse().Not.LazyLoad();

        }
    }
}
