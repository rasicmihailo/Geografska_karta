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
    public class UzvisenjeController : ApiController
    {
        //GET api/uzvisenje
        public IEnumerable<Uzvisenje> Get()
        {
            DataProvider provider = new DataProvider();

            IEnumerable<Uzvisenje> u = provider.vratiSvaUzvisenja();

            return u;
        }

        // GET api/uzvisenje/103
        public UzvisenjeView Get(int id)
        {
            DataProvider provider = new DataProvider();

            return provider.vratiUzvisenje(id);
        }

        // POST api/uzvisenje
        public int Post([FromBody]Uzvisenje u)
        {
            DataProvider provider = new DataProvider();

            return provider.dodajUzvisenjeu(u);
        }

        // PUT api/uzvisenje/169
        public int Put(int id, [FromBody]Uzvisenje u)
        {
            DataProvider provider = new DataProvider();

            return provider.azurirajUzvisenje(id, u);
        }

        // DELETE api/uzvisenje/177
        public int Delete(int id)
        {
            DataProvider provider = new DataProvider();

            return provider.obrisiUzvisenje(id);
        }

    }
}
