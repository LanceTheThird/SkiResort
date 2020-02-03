using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Turnstile.Models;
using Turnstile.Services.Abstract;

namespace Turnstile.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TurnstileController : ControllerBase
    {
        protected ITurnstileService _turnstileService;
        public TurnstileController(ITurnstileService turnstileService)
        {
            _turnstileService = turnstileService;
        }

        [HttpPost]
        public string Post([FromBody] TurnstileRequest value)
        {
            //var model = JsonConvert.DeserializeObject<TurnstileRequest>(value);
            return JsonConvert.SerializeObject(_turnstileService.Enter(value));
        }

        // GET: api/Turnstile
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }
    }
}
