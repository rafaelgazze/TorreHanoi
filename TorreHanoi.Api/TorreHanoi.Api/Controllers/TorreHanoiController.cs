using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using TorreHanoi.Domain;
using TorreHanoi.Services;

namespace TorreHanoi.Api.Controllers
{
    public class TorreHanoiController : ApiController
    {
        private readonly TorreHanoiService _torreHanoiService;
        private readonly MonitorarServices _monitorarServices;

        // GET api/values
        public TorreHanoiController(TorreHanoiService torreHanoiService, MonitorarServices monitorarServices)
        {
            _torreHanoiService = torreHanoiService;
            _monitorarServices = monitorarServices;
        }

        // GET api/values/5
        [HttpGet]
        public IHttpActionResult Monitorar(Guid id)
        {
            return Ok(_monitorarServices.Movimentos(id));
        }

        // POST api/values
        [HttpPost]
        public async Task<IHttpActionResult> Post(TorreHanoiDto torreHanoiDto)
        {
            return Ok(await _torreHanoiService.Start(torreHanoiDto));
        }


    }
}
