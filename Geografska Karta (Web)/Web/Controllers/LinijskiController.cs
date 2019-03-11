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
    public class LinijskiController : ApiController
    {
        //GET api/linijski
        public IEnumerable<LinijskiObjekat> Get()
        {
            DataProvider provider = new DataProvider();

            IEnumerable<LinijskiObjekat> lin = provider.vratiLinijske();

            return lin;
        }

        // GET api/linijski/5
        public LinijskiObjekatView Get(int id)
        {
            DataProvider provider = new DataProvider();

            return provider.vratiLinijskiObjekat(id);
        }

        // POST api/linijski
        public int Post([FromBody]LinijskiObjekat l)
        {
            DataProvider provider = new DataProvider();

            return provider.dodajLinijski(l);
        }

        // PUT api/linijski/164
        public int Put(int id, [FromBody]LinijskiObjekat l)
        {
            DataProvider provider = new DataProvider();

            return provider.azurirajLinijski(id, l);
        }

        // DELETE api/linijski/123
        public int Delete(int id)
        {
            DataProvider provider = new DataProvider();

            return provider.obrisiLinijski(id);
        }


    }
}
