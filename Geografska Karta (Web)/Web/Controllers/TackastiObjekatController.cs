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
    public class TackastiObjekatController : ApiController
    {
        // GET api/tackastiobjekat
        public IEnumerable<TackastiObjekat> Get()
        {
            DataProvider provider = new DataProvider();

            IEnumerable<TackastiObjekat> tackastiObjekti = provider.GetTackaste();

            return tackastiObjekti;
        }

        // GET api/tackastiobjekat/201
        public TackastiObjekatView Get(int id)
        {
            DataProvider provider = new DataProvider();

            return provider.GetTackstiObjekatView(id);
        }

        // POST api/tackastiobjekat
        public int Post([FromBody]TackastiObjekat t)
        {
            DataProvider provider = new DataProvider();

            return provider.AddTackasti(t);
        }

        // PUT api/tackastiobjekat/201
        public int Put(int id, [FromBody]TackastiObjekat t)
        {
            DataProvider provider = new DataProvider();

            return provider.UpdateTacksati(id, t);
        }

        // DELETE api/tackastiobjekat/201
        public int Delete(int id)
        {
            DataProvider provider = new DataProvider();

            return provider.RemoveTackasti(id);
        }
    }
}