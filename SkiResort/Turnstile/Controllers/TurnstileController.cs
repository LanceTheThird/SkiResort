using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
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
        public /*JsonResult*/void Enter([FromBody] string value)
        {
            //return Json(_turnstileService.Enter(value), JsonRequestBehavior.AllowGet) ;
        }

        // GET: api/Turnstile
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Turnstile/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Turnstile
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Turnstile/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
