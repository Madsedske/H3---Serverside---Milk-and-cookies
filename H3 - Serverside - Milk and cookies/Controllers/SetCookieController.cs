using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace H3___Serverside___Milk_and_cookies.Controllers
{
    [Produces("application/json")]
    [Route("api/SetCookie")]
    public class SetCookieController : Controller
    {
        // GET: api/SetCookie
        [HttpGet]
        public string Get(string favoriteMilkshake)
        {
            CookieOptions co = new CookieOptions();
            co.Expires = DateTimeOffset.Now.AddMinutes(1);
            Response.Cookies.Append("favoriteMilkshake", favoriteMilkshake, co);
            //do stuff her
            return favoriteMilkshake;
        }

        // GET: api/SetCookie
        [HttpGet]
        [Route("[action]")]
        public string GetFromCookie()
        {
            if (Request.Cookies["favoriteMilkshake"] != null)
            {
                return Request.Cookies["favoriteMilkshake"];
            }
            else
            {
                return "Unknown";
            }
            
        }
    }
}
