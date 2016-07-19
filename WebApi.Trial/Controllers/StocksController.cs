using System.Net;
using System.Web.Http;
using System.Web.Http.Description;
using WebApi.Trial.Common.Attributes;
using WebApi.Trial.Models;

namespace WebApi.Trial.Controllers
{
    [RoutePrefix("api/stocks")]
    public class StocksController : ApiController
    {
        [HttpGet, Route("{symbol}", Name = "Get"), ResponseType(typeof(Stock))]
        public IHttpActionResult Get(string symbol)
        {
            return Ok(new Stock());
        }

        [HttpPost]
        public IHttpActionResult Create(Stock stock)
        {
            //if (!ModelState.IsValid)
            //{
            //    return BadRequest(ModelState); 
            //}

            return CreatedAtRoute("Get", new { symbol = stock.Symbol }, stock);
        }

        [HttpPut]
        [BypassModelStateValidation]
        public IHttpActionResult Update(Stock stock)
        {
            //if (!ModelState.IsValid)
            //{
            //    return BadRequest(ModelState);
            //}

            return StatusCode(HttpStatusCode.NoContent);
        }
    }
}
