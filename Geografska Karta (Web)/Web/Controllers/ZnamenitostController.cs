using GeografskaKartaNovo.DTOs;
using GeografskaKartaNovo;
using GeografskaKartaNovo.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace Web.Controllers
{
    public class ZnamenitostController : ApiController
    {

        // GET api/vojnik
        public IEnumerable<Znamenitost> Get()
        {
            DataProvider provider = new DataProvider();

            IEnumerable<Znamenitost> znamenitosti = provider.GetZnamenitosti();

            return znamenitosti;
        }

        // GET api/znamenitost/201
        public ZnamenitostView Get(int id)
        {
            DataProvider provider = new DataProvider();

            return provider.GetZnamenitostView(id);
        }

        // POST api/znamenitost
        public int Post([FromBody]Znamenitost z)
        {
            DataProvider provider = new DataProvider();

            return provider.AddZnamenitost(z);
        }

        // PUT api/znamenitost/201
        public int Put(int id, [FromBody]Znamenitost z)
        {
            DataProvider provider = new DataProvider();
            
            return provider.UpdateZnamenitost(id, z);
        }

        // DELETE api/znamenitost/201
        public int Delete(int id)
        {
            DataProvider provider = new DataProvider();

            return provider.RemoveZnamenitost(id);
        }
    }
}