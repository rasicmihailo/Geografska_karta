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
    public class KoordinateController : ApiController
    {

        //GET api/koordinate
        public IEnumerable<Koordinate> Get()
        {
            DataProvider provider = new DataProvider();

            IEnumerable<Koordinate> k = provider.vratiSveKoordinate();

            return k;
        }

        // GET api/koordinate/304
        public KoordinateView Get(int id)
        {
            DataProvider provider = new DataProvider();

            return provider.vratiKoordinatu(id);
        }

        // POST api/koordinate
        public int Post([FromBody]Koordinate k)
        {
            DataProvider provider = new DataProvider();

            return provider.dodajKoordinatu(k);
        }

        // PUT api/koordinate/381
        public int Put(int id, [FromBody]Koordinate k)
        {
            DataProvider provider = new DataProvider();

            return provider.azurirajKoordinate(id, k);
        }

        // DELETE api/koordinate/342
        public int Delete(int id)
        {
            DataProvider provider = new DataProvider();

            return provider.obrisiKoordinate(id);
        }

    }
}
