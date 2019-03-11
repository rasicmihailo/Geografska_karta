using GeografskaKartaNovo;
using GeografskaKartaNovo.DTOs;
using GeografskaKartaNovo.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace Web.Controllers
{
    public class PovrsinskiObjekatController : ApiController
    {
        // GET api/povrsinskiobjekat
        public IEnumerable<PovrsinskiObjekat> Get()
        {
            DataProvider provider = new DataProvider();

            IEnumerable<PovrsinskiObjekat> povrsinskiObjekti = provider.GetPovrsinske();

            return povrsinskiObjekti;
        }

        // GET api/povrsinskiobjekat/201
        public PovrsinskiObjekatView Get(int id)
        {
            DataProvider provider = new DataProvider();

            return provider.GetPovrsinskiObjekatView(id);
        }

        // POST api/povrsinskiobjekat
        public int Post([FromBody]PovrsinskiObjekat p)
        {
            DataProvider provider = new DataProvider();

            return provider.AddPovrsinski(p);
        }

        // PUT api/povrsinskiobjekat/201
        public int Put(int id, [FromBody]PovrsinskiObjekat p)
        {
            DataProvider provider = new DataProvider();

            return provider.UpdatePovrsinski(id, p);
        }

        // DELETE api/povrsinskiobjekat/201
        public int Delete(int id)
        {
            DataProvider provider = new DataProvider();

            return provider.RemovePovrsinski(id);
        }
    }
}