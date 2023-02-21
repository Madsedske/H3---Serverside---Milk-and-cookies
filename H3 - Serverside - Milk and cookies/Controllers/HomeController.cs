using H3___Serverside___Milk_and_cookies.Controllers.Helper;
using H3___Serverside___Milk_and_cookies.Data;
using Microsoft.AspNetCore.Mvc;

namespace H3___Serverside___Milk_and_cookies.Controllers
{

    [Produces("application/json")]
    [Route("api/Home")]
    public class HomeController : Controller
    {
        // GET: api/Home
        [HttpGet]
        public ActionResult Get()
        {
            var myComplexObject = HttpContext.Session.GetObjectFromJson<Product>("Test");
            return Ok(myComplexObject);
        }
    }
}
