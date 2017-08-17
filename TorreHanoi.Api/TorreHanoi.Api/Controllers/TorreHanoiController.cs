using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TorreHanoi.Domain;

namespace TorreHanoi.Api.Controllers
{
    public class TorreHanoiController : ApiController
    {
        // GET api/values
        

        // GET api/values/5
        [HttpGet]
        public IHttpActionResult Monitorar(Guid id)
        {
            return Ok();
        }

        // POST api/values
        [HttpPost]
        public IHttpActionResult Post(TorreHanoiDto torreHanoiDto)
        {
            return Ok();
        }
        

    }
}
