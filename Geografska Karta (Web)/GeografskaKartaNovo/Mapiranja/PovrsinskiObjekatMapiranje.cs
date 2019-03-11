using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using GeografskaKartaNovo.Entiteti;

namespace GeografskaKartaNovo.Mapiranja
{
    public class PovrsinskiObjekatMapiranje : SubclassMap<PovrsinskiObjekat>
    {
        public PovrsinskiObjekatMapiranje()
        {
            Table("POVRSINSKI_OBJEKAT");

            KeyColumn("ID");

            //HasManyToMany(x => x.Lista_Linijskih_objekata)
            //   .Table("SADRZI_LIN")
            //   .ParentKeyColumn("ID0")
            //   .ChildKeyColumn("ID1")
            //   .Cascade.All();

            //HasMany(x => x.Lista_SadrziLin).KeyColumn("ID0").Cascade.All().Inverse().LazyLoad();

        }


    }
    public class UzvisenjeMapiranje : SubclassMap<Uzvisenje>
    {
        public UzvisenjeMapiranje()
        {
            Table("UZVISENJE");

            KeyColumn("ID");

            Map(x => x.Nadmorska_visina).Column("NADMORSKA_VISINA");

            //veza 1:N Uzvisenje - ListaVrhova
            //HasMany(x => x.Lista_Vrhova).KeyColumn("ID_UZVISENJA").Cascade.All().Inverse().LazyLoad();


            //veza N:M Uzvisenje - GeografskiObjekat
            //HasManyToMany(x => x.Lista_Geografskih_objekata)
            //    .Table("SADRZI_GEOG")
            //    .ParentKeyColumn("ID0")
            //    .ChildKeyColumn("ID1")
            //    .Cascade.All();

            //HasMany(x => x.Lista_SadrziGeog).KeyColumn("ID0").Cascade.All().Inverse().LazyLoad();
        }

    }

    public class VodnaPovrsinaMapiranje : SubclassMap<VodnaPovrsina>
    {
        public VodnaPovrsinaMapiranje()
        {
            Table("VODNA_POVRSINA");

            KeyColumn("ID");

            Map(x => x.Tip_Vode).Column("TIP_VODE");
        }
    }

}
