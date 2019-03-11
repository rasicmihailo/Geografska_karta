using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using GeografskaKartaNovo.Entiteti;

namespace GeografskaKartaNovo.Mapiranja
{
    public class LinijskiObjekatMapiranje : SubclassMap<LinijskiObjekat>
    {
        public LinijskiObjekatMapiranje()
        {
            Table("LINIJSKI_OBJEKAT");

            KeyColumn("ID");

            Map(x => x.Duzina).Column("DUZINA");
            Map(x => x.Opis_Objekta).Column("OPIS_OBJEKTA");
            Map(x => x.Tip_Objekta).Column("TIP_OBJEKTA");


            //veza 1:N Linijski-Koordinate
            //HasMany(x => x.ListaKoordinata).KeyColumn("ID_LINIJSKOG_OBJEKTA").Cascade.All().Inverse().LazyLoad();


            //veza N:M Linijski-Tackasti
            //HasManyToMany(x => x.Lista_Tackastih_objekata)
            //    .Table("SADRZI_TAC")
            //    .ParentKeyColumn("ID0")
            //    .ChildKeyColumn("ID1")
            //    .Cascade.All();

            //HasMany(x => x.Lista_SadrziTac).KeyColumn("ID0").Cascade.All().Inverse().LazyLoad();


            //veza N:M Linijski-Povrsinski
            //HasManyToMany(x => x.Lista_Povrsinskih_objekata)
            //   .Table("SADRZI_LIN")
            //   .ParentKeyColumn("ID1")
            //   .ChildKeyColumn("ID0")
            //   .Cascade.All();

            //HasMany(x => x.Lista_SadrziLin).KeyColumn("ID1").Cascade.All().Inverse().LazyLoad();

        }
    }
}
