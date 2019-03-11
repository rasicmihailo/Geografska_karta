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
    public class VodnaPovrsinaController : ApiController
    {
        // GET api/vodnapovrsina
        public IEnumerable<VodnaPovrsina> Get()
        {
            DataProvider provider = new DataProvider();

            IEnumerable<VodnaPovrsina> vodnaPovrsine = provider.GetVodne();

            return vodnaPovrsine;
        }

        // GET api/vodnapovrsina/201
        public VodnaPovrsinaView Get(int id)
        {
            DataProvider provider = new DataProvider();

            return provider.GetVodnaPovrsinaView(id);
        }

        // POST api/vodnapovrsina
        public int Post([FromBody]VodnaPovrsina v)
        {
            DataProvider provider = new DataProvider();

            return provider.AddVodna(v);
        }

        // PUT api/vodnapovrsina/201
        public int Put(int id, [FromBody]VodnaPovrsina v)
        {
            DataProvider provider = new DataProvider();

            return provider.UpdateVodna(id, v);
        }

        // DELETE api/vodnapovrsina/201
        public int Delete(int id)
        {
            DataProvider provider = new DataProvider();

            return provider.RemoveVodna(id);
        }
    }
}