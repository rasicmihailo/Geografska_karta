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
    public class GeografskiController : ApiController
    {
        //GET api/geografski
        public IEnumerable<GeografskiObjekat> Get()
        {
            DataProvider provider = new DataProvider();

            IEnumerable<GeografskiObjekat> geog = provider.vratiGeografske();

            return geog;
        }

        // GET api/geografski/6
        public GeografskiObjekatView Get(int id)
        {
            DataProvider provider = new DataProvider();

            return provider.vratiGeografskiObjekat(id);
        }

        // POST api/geografski
        public int Post([FromBody]GeografskiObjekat g)
        {
            DataProvider provider = new DataProvider();

            return provider.dodajGeografski(g);
        }

        // PUT api/geografski/161
        public int Put(int id, [FromBody]GeografskiObjekat g)
        {
            DataProvider provider = new DataProvider();

            return provider.azurirajGeografski(id, g);
        }

        // DELETE api/geografski/159
        public int Delete(int id)
        {
            DataProvider provider = new DataProvider();

            return provider.obrisiGeografski(id);
        }

    }
}
