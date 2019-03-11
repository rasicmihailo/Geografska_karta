using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using GeografskaKartaNovo.Entiteti;

namespace GeografskaKartaNovo.Mapiranja
{
    public class ListaVrhovaMapiranje : ClassMap<ListaVrhova>
    {
        public ListaVrhovaMapiranje()
        {
            Table("LISTA_VRHOVA");

            Id(x => x.Id).Column("ID").GeneratedBy.TriggerIdentity();


            Map(x => x.Ime).Column("IME_VRHA");
            Map(x => x.Nadmorska_visina).Column("NADMORSKA_VISINA");

            References(x => x.Id_Uzvisenja).Column("ID_UZVISENJA").LazyLoad();

        }
    }
}
