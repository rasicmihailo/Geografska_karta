using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using FluentNHibernate.Mapping;
using GeografskaKartaNovo.Entiteti;

namespace GeografskaKartaNovo.Mapiranja

{
    public class TackastiObjekatMapiranje : SubclassMap<TackastiObjekat>
    {
        
        public TackastiObjekatMapiranje()
        {
            
            
            Table("TACKASTI_OBJEKAT");

            KeyColumn("ID");

            Map(x => x.X_tac).Column("X_TAC");
            Map(x => x.Y_tac).Column("Y_TAC");
            Map(x => x.F_naseljeno).Column("F_NASELJENO");
            Map(x => x.Broj_Stanovnika).Column("BROJ_STANOVNIKA");
            Map(x => x.Datum_Osnivanja).Column("DATUM_OSNIVANJA");
            Map(x => x.Opstina).Column("OPSTINA");
            Map(x => x.F_turisticko).Column("F_TURISTICKO");
            Map(x => x.Datum_status).Column("DATUM_STATUS");
            Map(x => x.Tip_turizma).Column("TIP_TURIZMA");
            Map(x => x.Tip_naselja).Column("TIP_NASELJA");

            //veza 1:N Tackasti - Znamenitosti
            HasMany(x => x.Lista_Znamenitosti).KeyColumn("ID_NASELJENOG_MESTA").Cascade.All().Inverse().Not.LazyLoad();


            //veza N:M Tackasti : Linijski
            //HasManyToMany(x => x.Lista_Linijskih_objekata)
            //   .Table("SADRZI_TAC")
            //   .ParentKeyColumn("ID1")
            //   .ChildKeyColumn("ID0")
            //   .Cascade.All();

            HasMany(x => x.Lista_SadrziTac).KeyColumn("ID1").Cascade.All().Inverse().Not.LazyLoad();
        }

    }
}
