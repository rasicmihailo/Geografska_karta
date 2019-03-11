using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using GeografskaKartaNovo.DTOs;
using GeografskaKartaNovo;
using GeografskaKartaNovo.Entiteti;

namespace Web.Controllers
{
    public class VrhoviController : ApiController
    {
        //GET api/vrhovi
        public IEnumerable<ListaVrhova> Get()
        {
            DataProvider provider = new DataProvider();

            IEnumerable<ListaVrhova> v = provider.vratiSveVrhove();

            return v;
        }

        // GET api/vrhovi/411
        public ListaVrhovaView Get(int id)
        {
            DataProvider provider = new DataProvider();

            return provider.vratiVrh(id);
        }

        // POST api/vrhovi
        public int Post([FromBody]ListaVrhova v)
        {
            DataProvider provider = new DataProvider();

            return provider.dodajVrh(v);
        }

        // PUT api/vrhovi/441
        public int Put(int id, [FromBody]ListaVrhova v)
        {
            DataProvider provider = new DataProvider();

            return provider.azurirajVrh(id, v);
        }

        // DELETE api/vrhovi/442
        public int Delete(int id)
        {
            DataProvider provider = new DataProvider();

            return provider.obrisiVrh(id);
        }

    }
}
